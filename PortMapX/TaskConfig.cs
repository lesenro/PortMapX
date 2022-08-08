using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchSocket.Core.Config;
using TouchSocket.Sockets;

namespace PortMapX
{
    public class TaskConfig
    {
        public event Action<TaskConfig> ServerStop;
        public event Action<string> OnLogs;
        [JsonIgnore]
        public bool is_runing { get; set; }
        [JsonIgnore]
        public string runState
        {
            get
            {
                return is_runing ? "运行中" : "未运行";
            }
        }
        [JsonIgnore]
        public string forwardStr
        {
            get
            {
                return string.Join(",", forwards);
            }
        }

        public int id { get; set; } = 0;
        public int backid { get; set; }
        public int GetBackId()
        {
            if (forwards.Count > 0 && forwards.Find(x => x.id == backid) == null)
            {
                return forwards.First().id;
            }
            else
            {
                return backid;
            }
        }
        public string protocol { get; set; } = "UDP";
        public int timeout { get; set; } = 5 * 1000;
        public AddrInfo monitor { get; set; } = new AddrInfo { ip = "Any", port = 1111 };
        public List<AddrInfo> forwards { get; set; } = new List<AddrInfo>();
        private UdpSession udpSvr;
        private TcpService tcpSvr;

        private int bufferLen = 1024;
        public ListViewItem ToListViewItem()
        {
            ListViewItem item = new ListViewItem();
            item.Text = monitor.ToString();
            item.SubItems.Add(protocol);
            item.SubItems.Add(timeout.ToString());
            item.SubItems.Add(string.Join(",", forwards));
            item.Tag = this;
            item.Name = id.ToString();
            return item;
        }
        public void UpdateValue(TaskConfig task)
        {
            protocol = task.protocol;
            monitor = task.monitor;
            timeout = task.timeout;
            forwards = task.forwards;
            backid = task.backid;
        }
        public void Start()
        {
            if (protocol == "UDP")
            {
                Task.Run(StartUdp);
            }
            else if (protocol == "TCP")
            {
                Task.Run(StartTcp);
            }
            is_runing = true;
        }
        public override string ToString()
        {
            return monitor.ToString();
        }
        public void Stop()
        {
            //stoping = true;
            if (protocol == "UDP")
            {
                udpSvr.Stop();
            }
            else if (protocol == "TCP")
            {
                tcpSvr.Stop();
            }
            is_runing = false;
            //stoping = false;
            ServerStop?.Invoke(this);
            WriteLogs($"{protocol.ToLower()}://{monitor.ip}:{monitor.port}\t服务已停止");
        }
        private void WriteLogs(string log)
        {
            OnLogs?.Invoke($"[{DateTime.Now.ToString("HH:mm:ss")}] {log}");
        }
        private void StartUdp()
        {
            IPEndPoint ip;
            try
            {
                ip = new IPEndPoint(IPAddress.Parse(monitor.ip), monitor.port);
            }
            catch
            {
                ip = new IPEndPoint(IPAddress.Any, monitor.port);
            }
            udpSvr = new UdpSession();
            udpSvr.Received += (remote, byteBlock, requestInfo) =>
            {
                UdpDataForward(byteBlock.Buffer.Take(byteBlock.Len).ToArray(), remote);
            };
            udpSvr.Setup(new TouchSocketConfig()
             .SetBindIPHost(new IPHost(ip.Address, ip.Port)))
             .Start();
            WriteLogs($"{protocol.ToLower()}://{monitor.ip}:{monitor.port}\t服务已启动");

        }

        private void UdpDataForward(byte[] data, EndPoint Remote)
        {
            int minPort = 12345, maxPort = 65432;
            Random rand = new Random();
            WriteLogs($"收到{Remote.ToString()}数据: {string.Join(" ", data.Select(x => x.ToString("X2")).ToArray())} ({Encoding.Default.GetString(data)})");
            foreach (var fd in forwards)
            {
                IPEndPoint ip;
                try
                {
                    ip = new IPEndPoint(IPAddress.Parse(fd.ip), fd.port);
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, fd.port);
                }
                Task.Run(async () =>
                {
                    UdpSession client = new UdpSession();
                    DateTime lastTime = DateTime.Now;
                    TouchSocketConfig config = new TouchSocketConfig();
                    config.SetRemoteIPHost(new IPHost($"{fd.ip}:{fd.port}"))
                        .UsePlugin()
                        .SetBufferLength(bufferLen);

                    if (backid == fd.id)
                    {
                        //随机获取可用端口
                        IPGlobalProperties ipgl = IPGlobalProperties.GetIPGlobalProperties();
                        int port = rand.Next(minPort, maxPort);
                        var ports = ipgl.GetActiveUdpListeners().Select(x => x.Port).ToList();
                        while (ports.IndexOf(port) >= 0)
                        {
                            port = rand.Next(minPort, maxPort);
                        }
                        config.SetBindIPHost(port);
                        client.Received += (remote, byteBlock, requestInfo) =>
                        {
                            lastTime = DateTime.Now;
                            var buffer = byteBlock.Buffer.Take(byteBlock.Len).ToArray();
                            WriteLogs($"收到{fd.ip}:{fd.port}回复: {string.Join(" ", buffer.Select(x => x.ToString("X2")).ToArray())} ({Encoding.Default.GetString(buffer)})");
                            udpSvr.Send(Remote, buffer);
                            WriteLogs($"回复->{Remote.ToString()}");
                        };
                    }

                    client.Setup(config)
                        .Start();
                    client.Send(data);
                    WriteLogs($"转发->{fd.ip}:{fd.port}");
                    //等待延时
                    lastTime = DateTime.Now;
                    if (backid == fd.id)
                    {
                        while (true)
                        {
                            await Task.Delay(200);
                            if ((DateTime.Now - lastTime).TotalMilliseconds > timeout)
                            {
                                client.Stop();
                                client.SafeDispose();
                                WriteLogs($"error:等待回复超时-{fd.ip}:{fd.port}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        client.Stop();
                        client.SafeDispose();
                    }
                });
            }
        }

        private void StartTcp()
        {
            IPEndPoint ip;
            try
            {
                ip = new IPEndPoint(IPAddress.Parse(monitor.ip), monitor.port);
            }
            catch
            {
                ip = new IPEndPoint(IPAddress.Any, monitor.port);
            }

            tcpSvr = new TcpService();
            tcpSvr.Connecting += (client, e) => { };//有客户端正在连接
            tcpSvr.Connected += (client, e) => { };//有客户端连接
            tcpSvr.Disconnected += (client, e) => { };//有客户端断开连接
            tcpSvr.Received += (client, byteBlock, requestInfo) =>
            {
                //从客户端收到信息
                TcpDataForward(byteBlock.Buffer.Take(byteBlock.Len).ToArray(), client);
            };
            TouchSocketConfig cfg = new TouchSocketConfig();
            cfg.SetListenIPHosts(new IPHost[] { new IPHost(ip.Address, ip.Port) });
            tcpSvr.Setup(cfg);
            tcpSvr.Start();
        }


        private void TcpDataForward(byte[] data, SocketClient sclient)
        {

            WriteLogs($"收到{sclient.IP}:{sclient.Port}数据: {string.Join(" ", data.Select(x => x.ToString("X2")).ToArray())} ({Encoding.Default.GetString(data)})");
            foreach (var fd in forwards)
            {
                Task.Run(async () =>
                {
                    TcpClient tcpClient = new TcpClient();
                    tcpClient.Connected += (client, e) => { };//成功连接到服务器
                    tcpClient.Disconnected += (client, e) => { };//从服务器断开连接，当连接不成功时不会触发。
                    DateTime lastTime = DateTime.Now;
                    if (backid == fd.id)
                    {
                        tcpClient.Received += (client, byteBlock, requestInfo) =>
                        {
                            lastTime = DateTime.Now;
                            //从服务器收到信息
                            byte[] buffer = byteBlock.Buffer.Take(byteBlock.Len).ToArray();
                            WriteLogs($"收到{fd.ip}:{fd.port}回复: {string.Join(" ", buffer.Select(x => x.ToString("X2")).ToArray())} ({Encoding.Default.GetString(buffer)})");
                            tcpSvr.Send(sclient.ID, buffer);
                            WriteLogs($"回复->{sclient.IP}:{sclient.Port}");
                        };
                    }
                    //声明配置
                    TouchSocketConfig config = new TouchSocketConfig();
                    config.SetRemoteIPHost(new IPHost($"{fd.ip}:{fd.port}"))
                        .UsePlugin()
                        .SetBufferLength(bufferLen);

                    //载入配置
                    tcpClient.Setup(config);
                    tcpClient.Connect();
                    tcpClient.Send(data);
                    WriteLogs($"转发->{fd.ip}:{fd.port}");
                    //等待延时
                    lastTime = DateTime.Now;
                    if (backid == fd.id)
                    {
                        while (true)
                        {
                            await Task.Delay(200);
                            if ((DateTime.Now - lastTime).TotalMilliseconds > timeout)
                            {
                                tcpClient.Close();
                                tcpClient.SafeDispose();
                                WriteLogs($"error:等待回复超时-{fd.ip}:{fd.port}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        tcpClient.Close();
                        tcpClient.SafeDispose();
                    }
                });
            }
        }

    }
}
