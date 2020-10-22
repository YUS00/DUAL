using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Dades : Form
    {
        public Dades()
        {
            InitializeComponent();
            string macAdd ;
            macAdd = GetMacAddress();
            textBox1.Text = macAdd;
            string hostName;
            hostName = GetHostName();
            textBox2.Text = hostName;
        }

        private void Dades_Load(object sender, EventArgs e)
        {
            GetMacAddress();
        }
        private string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }
        private string GetHostName()
        {
            string HostName = Dns.GetHostName();
            return HostName;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SE HA GUARDADO");
        }

        private void Dades_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
