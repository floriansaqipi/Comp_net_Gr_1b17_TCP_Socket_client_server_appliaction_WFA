using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            serverIpAddress = getIpAddress(ipAddresstextBox.Text);
            port = getPort(portTextBox.Text);
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            sendCommandButton.Enabled = false;
        }


        #region Event Handlers
        
        //TODO: Florian Saqipi - implement this 
        private void connectButtonHandler(object sender, EventArgs e)
        {

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
                    statusTextBox.Text += CRLF + "Command sent to server: " + commandTextBox.Text;
                    commandTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                statusTextBox.Text += CRLF + "Problem sending command to the server!";
                statusTextBox.Text += CRLF + ex.ToString();
            }
        }
        
        #endregion Event Handlers


        private void processClientTransactions(object tcpClient)
        {

        }

        //TODO: Fjolla Ajeti - implement this
        private void disconnectFromServer()
        {
            try
            {
                client.Close();
                statusTextBox.invokeEx(stb => stb.Text += CRLF + "Disconnected from the server!");
                disconnectButton.invokeEx(db => db.Enabled = false);
                connectButton.invokeEx(cb => cb.Enabled = true);
                sendCommandButton.invokeEx(scb => scb.Enabled = false);
                statusTextBox.invokeEx(stb => stb.Text = string.Empty);

            }
            catch (Exception ex)
            {
                statusTextBox.invokeEx(stb => stb.Text += CRLF + "Problem disconnecting from the server.");
                statusTextBox.invokeEx(stb => stb.Text += CRLF + ex.ToString());
            }
            statusTextBox.invokeEx(stb => stb.Text = string.Empty);
        }


        #region Utility methods
        

        //TODO - Fjolla Ajeti implement this 
        private IPAddress getIPAddress(string ipAddress)
        {
            return null;
        }

        //TODO - Festim Kraniqi  implement this
        private int getPort(string serverPort) 
        {
            return -1;
        }


        #endregion Utility methods

    }
}
