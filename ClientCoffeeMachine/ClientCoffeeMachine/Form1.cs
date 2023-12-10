using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCoffeeMachine
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private const int port = 8888;
        public Form1()
        {
            InitializeComponent();
            udpClient = new UdpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                string messageToSend = txtMessageToSend.Text;
                byte[] sendBytes = Encoding.ASCII.GetBytes(messageToSend);
                udpClient.Send(sendBytes, sendBytes.Length, "127.0.0.1", port);

                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receivedBytes = udpClient.Receive(ref serverEndPoint);
                string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

                AppendToReceivedTextBox("Received message from server: " + receivedMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AppendToReceivedTextBox(string message)
        {
            if (txtReceived.InvokeRequired)
            {
                txtReceived.Invoke(new Action<string>(AppendToReceivedTextBox), new object[] { message });
            }
            else
            {
                txtReceived.AppendText(message + Environment.NewLine);
            }
        }
    }
}
