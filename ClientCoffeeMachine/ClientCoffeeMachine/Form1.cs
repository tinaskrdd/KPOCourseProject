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

        private void orderBtn_Click(object sender, EventArgs e)
        {
            int sugarChoice = 1;
            int drinkChoice = 1;
            Coffee orderedCoffee;
            if (espressoRB.Checked)
            {
                drinkChoice = 1;
            }
            else if (cappucinoRB.Checked)
            {
                drinkChoice = 2;
            }
            else if (americanoRB.Checked)
            {
                drinkChoice = 3;
            }
            else
            {
                drinkChoice = 4;
            }

            if (sweetRB.Checked)
            {
                sugarChoice = 1;
            }
            else if (semiSweetRB.Checked)
            {
                sugarChoice = 2;
            }
            else
            {
                sugarChoice = 3;
            }
            orderedCoffee = Controller.brewCoffee(drinkChoice, sugarChoice);
            //updateServer(orderedCoffee);
            string serverResponse = Controller.updateServer(orderedCoffee, udpClient, port);
            AppendToReceivedTextBox(serverResponse);
        }

        public void updateServer(Coffee cof)
        {
            try
            {
                string messageToSend = $"{cof.getCoffee()};{cof.getWater()};{cof.getSugar()};{cof.getMilk()}";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
