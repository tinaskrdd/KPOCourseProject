using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerCoffeeMachine
{
    public partial class Form1 : Form
    {
        private TcpListener tcpListener;
        private Thread listenerThread;
        private const int port = 8888;
        private TcpClient client = null;

        public Form1()
        {
            InitializeComponent();
            InitTcpServer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serverMessageLabel.Text = "Server started. Waiting for messages...";
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
        }

        private void InitTcpServer()
        {
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, port);
            tcpListener = new TcpListener(endpoint);
            listenerThread = new Thread(new ThreadStart(ListenForClient));
            listenerThread.Start();
        }

        private void ListenForClient() 
        {
            tcpListener.Start();
            
            try
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                // remember connected client
                client = tcpClient;
                HandleClient(tcpClient);
            }
            catch (SocketException exception)
            {
                Console.WriteLine("SocketException: {0}", exception.Message);
            }
        }

        private void HandleClient(object clientObject)
        {
            TcpClient tcpClient = (TcpClient)clientObject;

            // Get the client's network stream for reading and writing
            NetworkStream networkStream = tcpClient.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while ((bytesRead = networkStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    AppendToReceivedTextBox(dataReceived);

                    // Echo the data back to the client
                    byte[] dataToSend = Encoding.ASCII.GetBytes("Server received: " + dataReceived);
                    networkStream.Write(dataToSend, 0, dataToSend.Length);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void SendMessageToClient()
        {
            string message = "Message from server to all clients!";
            byte[] dataToSend = Encoding.ASCII.GetBytes(message);

            try
            {
                NetworkStream clientStream = client.GetStream();
                clientStream.Write(dataToSend, 0, dataToSend.Length);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., client disconnected)
                Console.WriteLine($"Error sending message to client: {ex.Message}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null) client.Close();
            listenerThread.Abort();
            tcpListener.Stop();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void AppendToReceivedTextBox(string message)
        {
            if (historyMessageBox.InvokeRequired)
            {
                historyMessageBox.Invoke(new Action<string>(AppendToReceivedTextBox), new object[] { message });
            }
            else
            {
                historyMessageBox.AppendText(message + Environment.NewLine);
            }
        }
    }
}
