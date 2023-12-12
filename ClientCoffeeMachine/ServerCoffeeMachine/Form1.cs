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
using Microsoft.VisualBasic;
namespace ServerCoffeeMachine
{
    public partial class Form1 : Form
    {
        private UdpClient udpServer;
        private const int port = 8888;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStartServer_Click(sender, e);
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            udpServer = new UdpClient(port);
            AppendToReceivedTextBox("Server started. Waiting for messages...");

            // Start listening for messages asynchronously
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);

        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            byte[] receivedBytes = udpServer.EndReceive(ar, ref clientEndPoint);
            string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

            AppendToReceivedTextBox("Received message from client: " + receivedMessage);
            if (receivedMessage == "total")
            {

                AppendToReceivedTextBox("Sending total\n");
                byte[] sendBytes = Encoding.ASCII.GetBytes(Controller.getHowMuchIsLeft());
                udpServer.Send(sendBytes, sendBytes.Length, clientEndPoint);
            }
            else
            {
                AppendToReceivedTextBox("Updating storage\n");
                string[] parts = receivedMessage.Split(';');
                if (parts.Length == 5)
                {
                    int coffee = int.Parse(parts[1]);
                    int water = int.Parse(parts[2]);
                    int sugar = int.Parse(parts[3]);
                    int milk = int.Parse(parts[4]);
                    Controller.updateQuantities(coffee, water, sugar, milk);
                }
                Storage storageSingleTon = Storage.GetInstance();
                // SendMessage to the server
                string mes = $"Coffee = {storageSingleTon.remainingCoffee}; Water = {storageSingleTon.remainingWater};" +
                $" Sugar = {storageSingleTon.remainingSugar}; Milk = {storageSingleTon.remainingMilk}";
                string responseMessage = "Remaining storage: " + mes;
                byte[] sendBytes = Encoding.ASCII.GetBytes(responseMessage);
                udpServer.Send(sendBytes, sendBytes.Length, clientEndPoint);
            }
            
            // Continue listening for more messages
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
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

        private void waterBtn_Click(object sender, EventArgs e)
        {
            // Display an input dialog to enter a value
            string userInput = Interaction.InputBox("Enter the quantity of water added:", "Input Value", "");
            
            // Check if the user entered a value
            if (!string.IsNullOrEmpty(userInput))
            {
                int refill = int.Parse(userInput);
                Controller.replenishWater(refill);
            }
            else
            {
                MessageBox.Show("No value entered.", "Error");
            }
        }

        private void milkBtn_Click(object sender, EventArgs e)
        {
            // Display an input dialog to enter a value
            string userInput = Interaction.InputBox("Enter the quantity of milk added:", "Input Value", "");

            // Check if the user entered a value
            if (!string.IsNullOrEmpty(userInput))
            {
                int refill = int.Parse(userInput);
                Controller.replenishMilk(refill);
            }
            else
            {
                MessageBox.Show("No value entered.", "Error");
            }

        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            // Display an input dialog to enter a value
            string userInput = Interaction.InputBox("Enter the quantity of coffee added:", "Input Value", "");

            // Check if the user entered a value
            if (!string.IsNullOrEmpty(userInput))
            {
                int refill = int.Parse(userInput);
                Controller.replenishCoffee(refill);
            }
            else
            {
                MessageBox.Show("No value entered.", "Error");
            }
        }

        private void sugarBtn_Click(object sender, EventArgs e)
        {
            // Display an input dialog to enter a value
            string userInput = Interaction.InputBox("Enter the quantity of sugar added:", "Input Value", "");

            // Check if the user entered a value
            if (!string.IsNullOrEmpty(userInput))
            {
                int refill = int.Parse(userInput);
                Controller.replenishSugar(refill);
            }
            else
            {
                MessageBox.Show("No value entered.", "Error");
            }
        }
    }
}
