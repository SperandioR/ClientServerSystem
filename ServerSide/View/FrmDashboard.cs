using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerSide.View
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            meuIP();
        }
        void meuIP()
        {
            string ip = " ";
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress Ip in host.AddressList)
            {
                ip = Ip.ToString();
            }
            LbMeuIP.Text = ip;
        }
    }
}
