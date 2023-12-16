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
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace ServerCoffeeMachine
{
    public partial class Form1 : Form
    {
        string logFilePath;
        private UdpClient udpServer;
        private const int port = 8888;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            logFilePath = GetSavePathForDocument();
            createWordFile(logFilePath);
            btnStartServer_Click(sender, e);
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            udpServer = new UdpClient(port);
            AppendToReceivedTextBox("Server started. Waiting for messages...");
            AddTextToWordFile(logFilePath, "Server started. Waiting for messages..." + getCurrentTime() + Environment.NewLine);
            // Start listening for messages asynchronously
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            byte[] receivedBytes = udpServer.EndReceive(ar, ref clientEndPoint);
            string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

            AppendToReceivedTextBox("Received message from client: " + receivedMessage);
            AddTextToWordFile(logFilePath, "Received message from client: " + receivedMessage + getCurrentTime() + Environment.NewLine);
            if (receivedMessage == "total")
            {

                AppendToReceivedTextBox("Sending total\n");
                AddTextToWordFile(logFilePath, "Sending total" + getCurrentTime() + Environment.NewLine);
                byte[] sendBytes = Encoding.ASCII.GetBytes(Controller.getHowMuchIsLeft());
                udpServer.Send(sendBytes, sendBytes.Length, clientEndPoint);
            }
            else if (receivedMessage == "coffee")
            {
                MessageBox.Show("REPLENISH COFFEE");
            }
            else if (receivedMessage == "water")
            {
                MessageBox.Show("REPLENISH WATER");
            }
            else if (receivedMessage == "sugar")
            {
                MessageBox.Show("REPLENISH SUGAR");
            }
            else if (receivedMessage == "milk")
            {
                MessageBox.Show("REPLENISH MILK");
            }
            else
            {
                AppendToReceivedTextBox("Updating storage\n");
                AddTextToWordFile(logFilePath, "Updating storage" + getCurrentTime() + Environment.NewLine);
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
        private string GetSavePathForDocument()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }

                return string.Empty;
            }
        }

        private void createWordFile(string documentPath)
        {
            if (!string.IsNullOrEmpty(documentPath))
            {
                // Create Word application and document
                Word.Application word = new Word.Application();
                Word.Document doc = word.Documents.Add();

                try
                {
                    DateTime currentDate = DateTime.Now;

                    // Convert the current date to a string in a specific format (e.g., "yyyy-MM-dd HH:mm:ss")
                    string dateString = currentDate.ToString("yyyy-MM-dd"); // Change the format as needed

                    // insert text into the document
                    doc.Content.Text += dateString + " logFile created";
                    // Save the document to the user-selected path
                    doc.SaveAs(Path.GetFullPath(documentPath));

                    // Close the document and Word application
                    doc.Close();
                    word.Quit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    // Close Word application and the document in case of an error
                    doc?.Close();
                    word?.Quit();
                }
            }
        }
        private void AddTextToWordFile(string filePath, string newText)
        {
            if (File.Exists(filePath))
            {
                Word.Application word = new Word.Application();
                Word.Document doc = null;

                try
                {
                    // Open the existing Word document
                    doc = word.Documents.Open(filePath);

                    // Get the existing content
                    string existingText = doc.Content.Text;

                    // Append the new text to the existing content
                    existingText += Environment.NewLine + newText;

                    // Clear the document and add the updated content
                    doc.Content.Text = existingText;

                    // Save the changes
                    doc.Save();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error adding text to the document: {ex.Message}");
                }
                finally
                {
                    // Close Word application and the document
                    doc?.Close();
                    word?.Quit();
                }
            }
            else
            {
                throw new FileNotFoundException("The specified file does not exist.");
            }
        }

        private string getCurrentTime()
        {
            DateTime currentDateTime = DateTime.Now;

            string dateString = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss"); 
            return dateString;
        }
    }
}
