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
    public partial class FileExplorerForm : Form
    {
        //Constants
        private const string CRLF = "\r\n";

        //Fields
        private TcpClient client;
        private TextBox statusTextBox;
        private List<string> files;
        public FileExplorerForm()
        {
            InitializeComponent();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            openFileButton.Enabled = false;
            executeFileButton.Enabled = false;
            fileListView.Items.Clear();
            foreach (string file in files)
            {
                fileListView.Items.Add(file);
            }
        }

        private void openFileButtonHandler(object sender, EventArgs e)
        {
            string currentFile = fileListView.SelectedItems[0].Text;
            try
            {
                if (client.Connected)
                {
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine("GET_FILE_CONTENT");
                    writer.Flush();
                    writer.WriteLine(currentFile);
                    writer.Flush();
                    displayToTextBox("Requested content for file : " + currentFile);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                handleException("Problem sending command to the server!", ex);
            }
        }

        private void executeFileButtonHandler(object sender, EventArgs e)
        {
            string currentFile = fileListView.SelectedItems[0].Text;
            try
            {
                if (client.Connected)
                {
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine("EXECUTE_FILE");
                    writer.Flush();
                    writer.WriteLine(currentFile);
                    writer.Flush();
                    displayToTextBox("Requested executing file : " + currentFile);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                handleException("Problem sending command to the server!",ex);
            }
        }

        private void listViewClickHandler(object sender, EventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                openFileButton.Enabled = true;
                string[] fullFileName = fileListView.SelectedItems[0].Text.Split('.');
                if (fullFileName[1] != "html")
                {
                    executeFileButton.Enabled = false;
                    return;
                }
                executeFileButton.Enabled = true;
                return;
            }
            openFileButton.Enabled = false;

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
        public List<string> Files
        {
            get { return files; }
            set { files = value; }
        }
    }
}
