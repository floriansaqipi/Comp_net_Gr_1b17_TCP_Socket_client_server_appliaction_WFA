
using PrivilegedClient.Utils;
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

namespace PrivilegedClient
{
    public partial class PrivilegedClientForm : Form
    {
        // Constants
        private const string CRLF = "\r\n";
        private const string LOCALHOST = "127.0.0.1";
        private const int DEFAULT_PORT = 5000;

        // Fields
        private IPAddress serverIpAddress;
        private int port;
        private TcpClient client;

        //Forms
        private FileExplorerForm fileExplorerForm = new FileExplorerForm();
        private SimpleTextEditorForm simpleTextEditorForm = new SimpleTextEditorForm();


        public PrivilegedClientForm()
        {
            InitializeComponent();
            serverIpAddress = getIPAddress(ipAddressTextBox.Text);
            port = getPort(portTextBox.Text);
            clientDisconnectedButtonState();
        }


        #region Event Handlers

        private void connectButtonHandler(object sender, EventArgs e)
        {
            try
            {
                serverIpAddress = getIPAddress(ipAddressTextBox.Text);
                port = getPort(portTextBox.Text);

                client = new TcpClient(serverIpAddress.ToString(), port);
                Thread t = new Thread(processClientTransactions);
                t.IsBackground = true;
                t.Start(client);

                clientConnectedButtonState();
            }
            catch (Exception ex)
            {
                handleException("Problem connecting to the server.", ex);
                displayToTextBox("No server is found at that IP listening to that port");
            }
        }

        private void disconnectButtonHandler(object sender, EventArgs e)
        {
            disconnectFromServer();
        }
        private void sendCommandButtonHandler(object sender, EventArgs e)
        {
            if (commandTextBox.Text == string.Empty)
            {
                displayToTextBox("Can not send empty string as a command.");
                return;
            }
            try
            {
                if (client.Connected)
                {
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine(commandTextBox.Text);
                    writer.Flush();
                    displayToTextBox("Command sent to server: " + commandTextBox.Text);
                    commandTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                handleException("Problem sending command to the server!", ex);
            }
        }

        private void createFileButtonHandler(object sender, EventArgs e)
        {
            if(createFileNameTextBox.Text == string.Empty)
            {
                displayToTextBox("Create file text box can not be empty");
                return;
            }
            try
            {
                if (client.Connected)
                {
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine("CREATE_FILE");
                    writer.Flush();
                    writer.WriteLine(createFileNameTextBox.Text);
                    writer.Flush();
                    displayToTextBox("Create file req sent to the server. File Name: " + createFileNameTextBox.Text);
                    createFileNameTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                handleException("Problem sending command to the server!", ex);
            }
        }

        private void deleteFileButtonHandler(object sender, EventArgs e)
        {
            if (deleteFileNameTextBox.Text == string.Empty)
            {
                displayToTextBox("Delete file text box can not be empty");
                return;
            }
            try
            {
                if (client.Connected)
                {
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine("DELETE_FILE");
                    writer.Flush();
                    writer.WriteLine(deleteFileNameTextBox.Text);
                    writer.Flush();
                    displayToTextBox("Delete file req sent to the server. File Name:" + commandTextBox.Text);
                    deleteFileNameTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                handleException("Problem sending command to the server!",ex);
            }
        }

        private void fileExplorerButtonHandler(object sender, EventArgs e)
        {
            try
            {
                if (client.Connected)
                {
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine("GET_FILE_LIST");
                    writer.Flush();
                    displayToTextBox("File list req sent to the server.");

                }
            }
            catch (Exception ex)
            {
                handleException("Problem sending command to the server!", ex);
            }
        }

        #endregion Event Handlers   


        private void processClientTransactions(object tcpClient)
        {
            TcpClient client = (TcpClient)tcpClient;
            string input = string.Empty;
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());

                // Say Hello to the server once we connect...
                writer.WriteLine("Hello from a client!");
                writer.Flush();

                while (client.Connected)
                {
                    input = reader.ReadLine();  //block here until a server send something
                    if (input == null)
                    {
                        disconnectFromServer();
                    }
                    else
                    {
                        switch (input)
                        {
                            case "FILES_LIST_RES":
                                {
                                    getFiles(input, reader);
                                    break;
                                }
                            case "FILE_CONTENT_RES":
                                {
                                    string fileName = reader.ReadLine();
                                    getFileContent(input, fileName, reader);
                                    break;
                                }
                            default:
                                {
                                    displayToTextBoxInvoke(" Received from Server: " + input);
                                    break;
                                }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                handleExceptionInvoke("Connection has been terminated.", ex);
            }
            disconnectButton.invokeEx(dcb => dcb.Enabled = false);
            connectButton.invokeEx(cb => cb.Enabled = true);
        }

        private void disconnectFromServer()
        {
            try
            {
                client.Close();
                displayToTextBoxInvoke("Disconnected from the server!");
                disconnectButton.invokeEx(db => db.Enabled = false);
                connectButton.invokeEx(cb => cb.Enabled = true);
                sendCommandButton.invokeEx(scb => scb.Enabled = false);
                createFileButton.invokeEx(cb => cb.Enabled = false);
                deleteFileButton.invokeEx(db => db.Enabled = false);
                fileExplorerButton.invokeEx(feb => feb.Enabled = false);

            }
            catch (Exception ex)
            {
                handleExceptionInvoke("Problem disconnecting from the server.", ex);

            }
        }

        private void getFiles(string input, StreamReader reader)
        {
            try
            {
                List<string> files = new List<string>();
                string currentFile = string.Empty;
                while ((currentFile = reader.ReadLine()) != "END_OF_LIST")
                {
                    files.Add(currentFile);
                }
                displayToTextBoxInvoke("Received from Server: " + input);
                displayToTextBoxInvoke("Received " + files.Count + " files from server.");
                fileExplorerForm.Files = files;
                fileExplorerForm.Client = client;
                fileExplorerForm.StatusTextBox = statusTextBox;
                fileExplorerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                handleExceptionInvoke("Problem getting files from server.",ex);
            }
        }

        private void getFileContent(string input, string fileName, StreamReader reader)
        {
            try
            {
                List<string> fileLines = new List<string>();
                string line = string.Empty;
                while ((line = reader.ReadLine()) != "END_OF_FILE")
                {
                    fileLines.Add(line);
                }
                displayToTextBoxInvoke(" Received from Server: " + input);

                simpleTextEditorForm.FileLines = fileLines;
                simpleTextEditorForm.FileName = fileName;
                simpleTextEditorForm.StatusTextBox = statusTextBox;
                simpleTextEditorForm.Client = client;
                displayToTextBoxInvoke(" Received file: " + fileName + " content from server.");
                simpleTextEditorForm.ShowDialog();
            }
            catch (Exception ex)
            {
                statusTextBox.invokeEx(stb => stb.Text += CRLF + "Problem getting files from server.");
            }
        }

        #region Utility methods

        private IPAddress getIPAddress(string ipAddress)
        {
            IPAddress address = IPAddress.Parse(LOCALHOST);
            try
            {
                if(ipAddress == string.Empty) {
                    address = IPAddress.Parse(LOCALHOST);
                    displayToTextBox("No IP address entered - Client will try to connect to: " + address.ToString());
                }
                else if (!IPAddress.TryParse(ipAddress, out address))
                {
                    address = IPAddress.Parse(LOCALHOST);
                    displayToTextBox("Invalid IP address - Client will try to connect to: " + address.ToString());
                }
            }
            catch (Exception ex)
            {
                handleException("Invalid IP address - Client will connect to: " + address.ToString(), ex);
            }

            return address;
        }


        private int getPort(string serverPort)
        {
            int port = DEFAULT_PORT;

            try
            {
                if (portTextBox.Text == string.Empty)
                {
                    port = DEFAULT_PORT;
                    displayToTextBox("You entered no port number using port: " + port);
                }
                else if (!Int32.TryParse(serverPort, out port)
                    || Int32.Parse(portTextBox.Text) < 1024
                    || Int32.Parse(portTextBox.Text) > 65536)
                {
                    port = DEFAULT_PORT;
                    displayToTextBox("You entered an invalid port number. Using port: " + port);
                }
            }
            catch (Exception ex)
            {
                handleException("Invalid Port Value - Client will connect to port: " + serverPort.ToString(), ex);
            }

            return port;
        }


        #endregion Utility methods

        private void handleException(string message, Exception ex)
        {
            displayToTextBox(message);
            Console.WriteLine(ex.Message);
        }

        private void handleExceptionInvoke(string message, Exception ex)
        {
            displayToTextBoxInvoke(message);
            Console.WriteLine(ex.Message);
        }
        private void displayToTextBox(string text)
        {
            if (text == string.Empty) { return; }
            statusTextBox.Text += CRLF + text;
        }

        private void displayToTextBoxInvoke(string text)
        {
            if (text == string.Empty) { return; }
            statusTextBox.invokeEx(stb => stb.Text += CRLF + text);
        }
        private void clientConnectedButtonState()
        {
            connectButton.Enabled = false;
            disconnectButton.Enabled = true;
            sendCommandButton.Enabled = true;
            createFileButton.Enabled = true;
            deleteFileButton.Enabled = true;
            fileExplorerButton.Enabled = true;
        }
        private void clientDisconnectedButtonState()
        {
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            sendCommandButton.Enabled = false;
            createFileButton.Enabled = false;
            deleteFileButton.Enabled = false;
            fileExplorerButton.Enabled = false;
        }
    }
}
