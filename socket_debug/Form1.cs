using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace socket_debug
{
    public partial class Form1 : Form
    {
        private NetworkStream clientstream = null;
        private TcpClient client = null;
        private Thread recthread = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void connectbt_Click(object sender, EventArgs e)
        {
            if (connectbt.Text == "Connect")
            {
                IPAddress ip;
                try
                {
                    ip = IPAddress.Parse(ip_box.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("IP address error!\r\n" + ex.Message);
                    ip_box.Focus();
                    ip_box.SelectAll();
                    return;
                }
                int port;
                try
                {
                    port = int.Parse(port_box.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Port error!\r\n" + ex.Message);
                    port_box.Focus();
                    port_box.SelectAll();
                    return;
                }
                client = new TcpClient();
                try
                {
                    client.Connect(ip, port);
                }
                catch (Exception ex)
                {
                    status.Text = "error";
                    MessageBox.Show("Connect error!\r\n" + ex.Message);
                    return;
                }
                if (client.Connected) {
                    clientstream = client.GetStream();
                    Thread recthread = new Thread(recdata);
                    recthread.IsBackground = true;
                    recthread.Start();
                    status.Text = "connected";
                    connectbt.Text = "Disconnect";                    
                }
            }
            else
            {
                recthread.Abort();
                clientstream.Dispose();
                clientstream.Close();
                client.Close();
                connectbt.Text = "Connect"; 
                status.Text = "disconnected";
            }
        }

        private void recdata()
        {
            while (true)
            {
                byte[] data = new byte[512];
                try
                {
                    int reclen = clientstream.Read(data, 0, data.Length);

                    if (reclen != 0)
                    {
                        if (reishex.Checked)
                        {
                            recbox.BeginInvoke(new Action(() =>
                            {
                                recbox.AppendText(BitConverter.ToString(data, 0, reclen).Replace('-', ' ') + " ");
                            }));
                        }
                        else
                        {
                            recbox.BeginInvoke(new Action(() =>
                            {
                                recbox.AppendText(System.Text.Encoding.Default.GetString(data, 0, reclen));
                            }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    clientstream.Dispose();
                    clientstream.Close();
                    client.Close();
                    connectbt.BeginInvoke(new Action(() =>
                    {
                        connectbt.Text = "Connect";
                    }));
                    status.BeginInvoke(new Action(() =>
                    {
                        status.Text = "error";
                    }));
                    MessageBox.Show("Receive error!\r\n" + ex.Message);
                    return;
                }
                Thread.Sleep(100);
            }
       }
        private bool strtobyte(string str, out byte[] data)
        {
            string[] datastr = str.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            List<byte> datals = new List<byte>();
            try
            {
                foreach (string da in datastr)
                {
                    datals.Add(Convert.ToByte(da, 16));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                data = null;
                return false;
            }
            data = datals.ToArray();
            return true;
        }

        private void send_bt_Click(object sender, EventArgs e)
        {
            if (status.Text != "connected") { MessageBox.Show("Please connect first!"); return; }
            byte[] data = null;

            if (sdishex.Checked) { if (!strtobyte(sdbox.Text.Trim(), out data)) { return; } }
            else
            {
                data = System.Text.Encoding.Default.GetBytes(sdbox.Text.Trim());
            }

            try
            {
                clientstream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                recthread.Abort();
                clientstream.Dispose();
                clientstream.Close();
                client.Close();
                connectbt.Text = "Connect";
                status.Text = "error";
                MessageBox.Show("Send error!\r\n" + ex.Message);
            }
        }

        private void sdishex_CheckedChanged(object sender, EventArgs e)
        {
            if (sdishex.Checked)
            {

            }
        }
    }
}
