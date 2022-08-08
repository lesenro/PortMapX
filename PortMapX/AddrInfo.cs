using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortMapX
{
    public class AddrInfo
    {
        public int id { get; set; }
        public string ip { set; get; }
        public int port { get; set; }
        public override string ToString()
        {
            return $"{ip}:{port.ToString()}";
        }
        public void UpdateValue(AddrInfo addr)
        {
            ip = addr.ip;
            port = addr.port;
        }
    }
}
