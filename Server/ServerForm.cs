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
        private int clientCount;
        private bool keepWaiting;
        private IPAddress ipAddress = IPAddress.Any;
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
                if(!Int32.TryParse(portTextBox.Text, out port))
                {
                    displayToTextBox("You entered an invalid port number. Using port: " + port);
                }

                Thread t = new Thread(listenForIncomingConnections);
                t.Name = "Server Listener Thread";
                t.IsBackground = true;
                t.Start();

                serverStartedButtonState();

            } catch (Exception ex){
                displayToTextBox("Problem starting the server.");
                Console.WriteLine(ex.Message);
            }
        }

        //TODO : Festim Krasniqi - implement this method, needs to loop through list disconnect clients, stop listening also.
        private void stopServerButtonHandler(object sender, EventArgs e)
        {

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

                    clientCommandTextBox.Text = string.Empty;
                }
            }catch (Exception ex)
            {

            }
        }
        #endregion Event Handlers

        private void listenForIncomingConnections()
        {
            try
            {
                keepWaiting = true;
                listener = new TcpListener(ipAddress, port);
                listener.Start();
                displayToTextBox("Server started listening on port: " + port);

                while (keepWaiting)
                {
                    displayToTextBox("Waiting for incoming client connections...");
                    TcpClient client = listener.AcceptTcpClient(); //blocks until client connection accepted
                    displayToTextBox("Incoming client connection accepted...");
                    Thread t = new Thread(processClientRequests);
                    t.IsBackground = true;
                    t.Start(client);
                }
            } catch (SocketException se) 
            {
                displayToTextBox("Problem accepting Tcp Client!");
                Console.WriteLine(se.Message);
            } catch (Exception ex)
            {
                displayToTextBox("Problem starting server");
                Console.WriteLine(ex.Message);
            }
            displayToTextBox("Exiting listening thread...");
            statusTextBox.Text = string.Empty;
        }

        private void processClientRequests(object tcpClient)
        {
            TcpClient client = (TcpClient) tcpClient;
            clientList.Add(client);
            clientCount++;
            
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
                                displayToTextBox("From client: " + client.GetHashCode() + ": " + input);
                                writer.WriteLine("Server received: " + input);
                                writer.Flush();
                                break;
                            }
                    }
                }
            } catch (Exception ex) 
            {
                displayToTextBox("Problem processing client requests!");
                Console.WriteLine(ex.Message);
            }
            clientList.Remove(client);
            clientCount--;
            connectedClientsTextBox.Text = clientCount.ToString();
            displayToTextBox("Finished processing requests for client: " + client.GetHashCode());
        }

        private void handleException(string message, Exception ex)
        {
            displayToTextBox(message);
            Console.WriteLine(ex.Message);
        }
        private void displayToTextBox(string error)
        {
            if(error == string.Empty) { return; }
            statusTextBox.Text += CRLF  + error;  
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
