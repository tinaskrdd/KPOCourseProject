using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.IO;

namespace ClientCoffeeMachine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void addText(string msg)
        {
            textBox1.Text += msg + Environment.NewLine;
        }

        private void saveToWordFile_Click(object sender, EventArgs e)
        {
            // Prompt the user to select a file path for the document
            string documentPath = GetSavePathForDocument();

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
                    doc.Content.Text += dateString + Environment.NewLine + textBox1.Text;
                    // Save the document to the user-selected path
                    doc.SaveAs(Path.GetFullPath(documentPath));

                    // Close the document and Word application
                    doc.Close();
                    word.Quit();

                    // Open the created Word document
                    Process.Start("WINWORD.EXE", Path.GetFullPath(documentPath));
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
    }
}
