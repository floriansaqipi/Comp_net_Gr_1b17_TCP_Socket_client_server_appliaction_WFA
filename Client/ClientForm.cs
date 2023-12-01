using Client.Utils;
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

namespace Client
{
    public partial class ClientForm : Form
    {
            // Constants
        private const string CRLF = "\r\n";
        private const string LOCALHOST = "127.0.0.1";
        private const int DEFAULT_PORT = 5000;

        // Fields
        private IPAddress serverIpAddress;
        private int port;
        private TcpClient client;


         public ClientForm()
        {
            InitializeComponent();
            serverIpAddress = getIPAddress(ipAddressTextBox.Text);
            port = getPort(portTextBox.Text);
            clientDisconnectedButtonState();
        }


        #region Event Handlers
        
        //TODO: Florian Saqipi - implement this 
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
                handleException("Problem connecting to the server.",ex);
                displayToTextBox("No server is found at that IP listening to that port");
            }
        }

        //TODO: Fjolla Ajeti - implement this 
        private void disconnectButtonHandler(object sender, EventArgs e) 
        {
            disconnectFromServer();
        }
        private void sendCommandButtonHandler(object sender, EventArgs e)
        {
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
                writer.WriteLine("Hello from a client! Ready to do your bidding!");
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
                handleExceptionInvoke("Problem communicating with the server. Connection may have been intentionally disconnected.",ex);
            }
            disconnectButton.invokeEx(dcb => dcb.Enabled = false);
            connectButton.invokeEx(cb => cb.Enabled = true);
            //statusTextBox.invokeEx(stb => stb.Text = string.Empty);
            //add maybe send Command Button to false
        }

        //TODO: Fjolla Ajeti - implement this
        private void disconnectFromServer()
        {
            try
            {
                client.Close();
                displayToTextBoxInvoke("Disconnected from the server!");
                disconnectButton.invokeEx(db => db.Enabled = false);
                connectButton.invokeEx(cb => cb.Enabled = true);
                sendCommandButton.invokeEx(scb => scb.Enabled = false);

            }
            catch (Exception ex)
            {
                handleExceptionInvoke("Problem disconnecting from the server.",ex);

            }
        }


        #region Utility methods
        

        //TODO - Fjolla Ajeti implement this 
        private IPAddress getIPAddress(string ipAddress)
        {
            IPAddress address = IPAddress.Parse(LOCALHOST);
            try
            {
                if (!IPAddress.TryParse(ipAddress, out address))
                {
                    address = IPAddress.Parse(LOCALHOST);
                }
            }
            catch (Exception ex)
            {
                handleException("Invalid IP address - Client will connect to: " + address.ToString(),ex);
            }

            return address;
        }

        //TODO - Festim Kraniqi  implement this
        private int getPort(string serverPort) 
        {
            int port = DEFAULT_PORT;

            try
            {
                if (!Int32.TryParse(serverPort, out port)
                    || Int32.Parse(portTextBox.Text) < 1024
                    || Int32.Parse(portTextBox.Text) > 65536)
                {
                    port = DEFAULT_PORT;
                    displayToTextBox("You entered an invalid port number. Using other port");
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
            statusTextBox.invokeEx(stb => stb.Text = CRLF + text);
        }
        private void clientConnectedButtonState()
        {
            connectButton.Enabled = false;
            disconnectButton.Enabled = true;
            sendCommandButton.Enabled = true;
        }
        private void clientDisconnectedButtonState()
        {
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            sendCommandButton.Enabled = false;
        }
    }
}
