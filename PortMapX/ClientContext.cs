using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PortMapX
{
    public class ClientContext
    {
        public TcpClient Client;
        public Stream Stream;
        public byte[] Buffer = new byte[4];
        public MemoryStream Message = new MemoryStream();
    }
}
