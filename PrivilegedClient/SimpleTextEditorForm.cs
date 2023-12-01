using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivilegedClient
{
    public partial class SimpleTextEditorForm : Form
    {
        //Constants
        private const string CRLF = "\r\n";

        //Fields
        private List<string> fileLines = new List<string>();
        private TcpClient client;
        private TextBox statusTextBox;
        private string fileName;
        public SimpleTextEditorForm()
        {
            InitializeComponent();
        }

        private void onLoadForm(object sender, EventArgs e)
        {
            fileContentRichTextBox.Text = string.Empty;
            foreach (string line in fileLines)
            {
                fileContentRichTextBox.Text += line + CRLF;
            }
        }

        private void saveFileButtonHandler(object sender, EventArgs e)
        {
            try
            {
                if (client.Connected)
                {
                    string[] currentFileLines = fileContentRichTextBox.Lines;
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine("WRITE_FILE_CONTENT");
                    writer.Flush();
                    writer.WriteLine(fileName);
                    writer.Flush();
                    foreach (string line in currentFileLines)
                    {
                        writer.WriteLine(line);
                        writer.Flush();
                    }
                    writer.WriteLine("END_OF_FILE");
                    writer.Flush();
                    displayToTextBox("Requested write content for file : " + fileName);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                handleException("Problem sending command to the server!", ex);

            }
        }

        private void undoMenuItemClickHandler(object sender, EventArgs e)
        {
            fileContentRichTextBox.Undo();
        }

        private void redoMenuItemClickHandler(object sender, EventArgs e)
        {
            fileContentRichTextBox.Redo();
        }

        private void cutMenuItemClickHandler(object sender, EventArgs e)
        {
            fileContentRichTextBox.Cut();
        }

        private void copyMenuItemClickHandler(object sender, EventArgs e)
        {
            fileContentRichTextBox.Copy();
        }

        private void pasteMenuItemClickHandler(object sender, EventArgs e)
        {
            fileContentRichTextBox.Paste();
        }

        private void selectAllMenuItemClickHandler(object sender, EventArgs e)
        {
            fileContentRichTextBox.SelectAll();
        }

        private void fontMenuItemClickHandler(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            fileContentRichTextBox.SelectionFont = fontDialog.Font;
        }
        private void colorMenuItemClickHandler(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            fileContentRichTextBox.SelectionColor = colorDialog.Color;
        }

        private void handleException(string message, Exception ex)
        {
            displayToTextBox(message);
            Console.WriteLine(ex.Message);
        }

        private void displayToTextBox(string text)
        {
            if (text == string.Empty) { return; }
            statusTextBox.Text += CRLF + text;
        }


        public List<string> FileLines
        {
            get { return fileLines; }
            set { fileLines = value; }
        }

        public TcpClient Client
        {
            get { return client; }
            set { client = value; }
        }

        public TextBox StatusTextBox
        {
            get { return statusTextBox; }
            set { statusTextBox = value; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }

        }
    }
}
