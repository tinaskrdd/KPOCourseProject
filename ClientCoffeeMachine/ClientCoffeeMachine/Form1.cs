using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCoffeeMachine
{
    public partial class Form1 : Form
    {
        private string serverIpAddress = "127.0.0.1";
        private TcpClient tcpClient;
        private const int port = 8888;
        public Form1()
        {
            InitializeComponent();
            tcpClient = new TcpClient(serverIpAddress, port);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            NetworkStream networkStream = tcpClient.GetStream();
            byte[] dataToSend = Encoding.ASCII.GetBytes(txtMessageToSend.Text);
            txtMessageToSend.Text = "";

            // Send the message to the server
            networkStream.Write(dataToSend, 0, dataToSend.Length);

            // Receive the response from the server
            byte[] buffer = new byte[1024];
            int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            AppendToReceivedTextBox(response);
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpClient.Close();
        }
    }
}
