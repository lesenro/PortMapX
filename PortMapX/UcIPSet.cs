using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortMapX
{
    public partial class UcIPSet : UserControl
    {
        public UcIPSet()
        {
            InitializeComponent();
        }
        public void FillValue(AddrInfo inf)
        {
            txt_ip.Text = inf.ip;
            num_port.Value = inf.port;
        }
        public AddrInfo GetValue()
        {
            AddrInfo inf = new AddrInfo();
            inf.port = Convert.ToInt32(num_port.Value);
            inf.ip = txt_ip.Text;
            return inf;
        }
    }
}
