using Client.Utils;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class ServerForm : Form
    {
        //TODO: clean up handling errors
        //constants
        private const string CRLF = "\r\n";

        //fields
        private List<TcpClient> clientList = new List<TcpClient>();
        private TcpListener listener;
        private int clientCount = 0;
        private bool keepWaiting;
        private IPAddress ipAddress = IPAddress.Parse("192.168.100.25");
        private int port = 5000;

        public ServerForm()
        {
            InitializeComponent();
            serverClosedButtonState();
        }

        #region Event Handlers
        private void startServerButtonHandler(object sender, EventArgs e)
        {
            try
            {
                if(!Int32.TryParse(portTextBox.Text, out port)
                    || Int32.Parse(portTextBox.Text) < 1024
                    || Int32.Parse(portTextBox.Text) > 65536)
                {
                    port = 5000;
                    displayToTextBox("You entered an invalid port number. Using port: " + port);
                }

                Thread t = new Thread(listenForIncomingConnections);
                t.Name = "Server Listener Thread";
                t.IsBackground = true;
                t.Start();

                serverStartedButtonState();
                sendCommandButton.Enabled = false;

            } catch (Exception ex){
                handleException("Problem starting the server.",ex);
            }
        }

       
        private void stopServerButtonHandler(object sender, EventArgs e)
        {
            keepWaiting = false;
            displayToTextBox("Shutting down server, disconnecting all clients...");
            try
            {
                foreach (TcpClient client in clientList)
                {
                    client.Close();
                    connectedClientsTextBox.Text = clientCount.ToString();
                }
                clientList.Clear();
                listener.Stop();
            }
            catch (Exception ex)
            {
                handleException("Problem stopping the server, or client connections closed.",ex);
            }
            serverClosedButtonState();
        }

        private void sendCommandButtonHandler(object sender, EventArgs e)
        {
            try
            {
                foreach(TcpClient client in clientList)
                {
                    StreamWriter writer = new StreamWriter(client.GetStream());
                    writer.WriteLine(clientCommandTextBox.Text);
                    writer.Flush();

                }
            }catch (Exception ex)
            {
                handleException("Problem sending commands to clients...", ex);
            }
            clientCommandTextBox.Text = string.Empty;
        }
        #endregion Event Handlers

        private void listenForIncomingConnections()
        {
            try
            {
                keepWaiting = true;
                listener = new TcpListener(ipAddress, port);
                listener.Start();
                displayToTextBoxInvoke("Server started listening on port: " + port);

                while (keepWaiting)
                {
                    displayToTextBoxInvoke("Waiting for incoming client connections...");
                    TcpClient client = listener.AcceptTcpClient(); //blocks until client connection accepted
                    sendCommandButton.Enabled = true;
                    displayToTextBoxInvoke("Incoming client connection accepted...");
                    Thread t = new Thread(processClientRequests);
                    t.IsBackground = true;
                    t.Start(client);
                }
            } catch (SocketException se) 
            {
            } catch (Exception ex)
            {
                handleExceptionInvoke("Problem starting server",ex);
            }
            displayToTextBoxInvoke("Exiting listening thread...");
        }

        private void processClientRequests(object tcpClient)
        {
            TcpClient client = (TcpClient) tcpClient;
            clientList.Add(client);
            clientCount++;
            connectedClientsTextBox.invokeEx(cctx => cctx.Text = client.ToString());
            
            string input = string.Empty;

            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());

                while (client.Connected)
                {
                    input = reader.ReadLine(); //blocks until it receives something from the client
                    switch (input)
                    {
                        default:
                            {
                                displayToTextBoxInvoke("From client: " + client.GetHashCode() + ": " + input);
                                writer.WriteLine("Server received: " + input);
                                writer.Flush();
                                break;
                            }
                    }
                }
            } catch (SocketException se) 
            {
            } 
            catch (Exception ex)
            {
                handleExceptionInvoke("Problem processing client requests!", ex);
            }
            clientList.Remove(client);
            clientCount--;
            connectedClientsTextBox.invokeEx(cctx => cctx.Text = clientCount.ToString());
            displayToTextBoxInvoke("Finished processing requests for client: " + client.GetHashCode());

            if (clientCount == 0)
            {
                sendCommandButton.invokeEx(scb => scb.Enabled = false);
            }
        }

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
            if(text == string.Empty) { return; }
            statusTextBox.Text += CRLF  + text;  
        }

        private void displayToTextBoxInvoke(string text)
        {
            if (text == string.Empty) { return; }
            statusTextBox.invokeEx(stb => stb.Text += CRLF + text);
        }

        private void serverStartedButtonState()
        {
            startServerButton.Enabled = false;
            stopServerButton.Enabled = true;
            sendCommandButton.Enabled = true;
        }
        private void serverClosedButtonState()
        {
            startServerButton.Enabled = true;
            stopServerButton.Enabled = false;
            sendCommandButton.Enabled = false;
        }
    }
}
