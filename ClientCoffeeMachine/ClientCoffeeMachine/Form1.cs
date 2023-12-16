using Microsoft.VisualBasic;
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
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            udpClient = new UdpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            espressoRB.Checked = true;
            sugarFreeRB.Checked = true;
            updateTextboxes();
            check();
        }

    
      

        private void orderBtn_Click(object sender, EventArgs e)
        {
            form2.addText("order button pressed");
            check();
            updateTextboxes();
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
           // AppendToReceivedTextBox(serverResponse);
            form2.addText(serverResponse);
            updateTextboxes();
            MessageBox.Show("Here is your coffee. Thank you for your order");
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
                form2.addText("Received message from server: " + receivedMessage);
               // AppendToReceivedTextBox("Received message from server: " + receivedMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updateTextboxes()
        {
            int coffee, water, milk, sugar;
            string serverResources = Controller.requestTotal(udpClient, port);

            string[] parts = serverResources.Split(';');
            if (parts.Length == 4)
            {
                coffee = int.Parse(parts[0]);
                water = int.Parse(parts[1]);
                milk = int.Parse(parts[2]);
                sugar = int.Parse(parts[3]);
            }
            else
            {
                coffee = 0;
                water = 0;
                milk = 0;
                sugar = 0;
            }
            CoffeeRem.Text = coffee.ToString();
            WaterRem.Text = water.ToString();
            MilkRem.Text = milk.ToString();
            SugarRem.Text = sugar.ToString();

        }

        private void check()
        {
            orderBtn.Enabled = true;
            (int, int, int, int) resources;
            resources = Controller.checkBeforeBrewing(udpClient, port);
            int coffee, water, milk, sugar;
            coffee = resources.Item1;
            water = resources.Item2;
            milk = resources.Item3;
            sugar = resources.Item4;

            if (coffee < 30)
            {
                espressoRB.Enabled = false;
                cappucinoRB.Enabled = false;
                americanoRB.Enabled = false;
                sweetRB.Enabled = false;
                semiSweetRB.Enabled = false;
                sugarFreeRB.Enabled = false;
                orderBtn.Enabled = false;
                Controller.sendToServerCoffeeStatus(udpClient, port);
                MessageBox.Show("The coffee machine is out of order", "Apologies");

            } else if  (water < 400)  {
                espressoRB.Enabled = false;
                cappucinoRB.Enabled = false;
                americanoRB.Enabled = false;
                sweetRB.Enabled = false;
                semiSweetRB.Enabled = false;
                sugarFreeRB.Enabled = false;
                orderBtn.Enabled = false;
                Controller.sendToServerWaterStatus(udpClient, port);
                MessageBox.Show("The coffee machine is out of order", "Apologies");
            } else if (milk < 250)
            {
                espressoRB.Enabled = true;
                cappucinoRB.Enabled = false;
                americanoRB.Enabled = true;
                sweetRB.Enabled = true;
                semiSweetRB.Enabled = true;
                sugarFreeRB.Enabled = true;
                Controller.sendToServerMilkStatus(udpClient, port);
            } else
            {
                espressoRB.Enabled = true;
                cappucinoRB.Enabled = true;
                americanoRB.Enabled = true;
                sweetRB.Enabled = true;
                semiSweetRB.Enabled = true;
                sugarFreeRB.Enabled = true;
            }

            if(sugar < 10 && sugar > 5)
            {
                sweetRB.Enabled = false;
                semiSweetRB.Enabled = true;
                sugarFreeRB.Enabled = true;
                Controller.sendToServerSugarStatus(udpClient, port);
            } else if (sugar < 5)
            {
                sweetRB.Enabled = false;
                semiSweetRB.Enabled = false;
                sugarFreeRB.Enabled = true;
            }
            else
            {
                sweetRB.Enabled = true;
                semiSweetRB.Enabled = true;
                sugarFreeRB.Enabled = true;
            }
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display an input dialog to enter a value
            string userInput = Interaction.InputBox("Enter your password", "", "");

            // Check if the user entered a value
            if (!string.IsNullOrEmpty(userInput))
            {
                if (userInput == "123")
                {
                    check();
                    updateTextboxes();
                }

            }
            else
            {
                MessageBox.Show("Access Denied", "Error");
            }
            MessageBox.Show("Successfully Restarted");
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {

            // Display an input dialog to enter a value
            string userInput = Interaction.InputBox("Enter your password", "", "");

            // Check if the user entered a value
            if (!string.IsNullOrEmpty(userInput))
            {
                if (userInput == "123")
                {
                    DialogResult dialogResult = form2.ShowDialog();
                }
              
            }
            else
            {
                MessageBox.Show("Access Denied", "Error");
            }
           
        }
    }
}
