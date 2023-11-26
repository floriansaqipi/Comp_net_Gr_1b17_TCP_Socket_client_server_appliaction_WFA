using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class ServerForm : Form
    {

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
        private void stopServerButtonHandler(object sender, EventArgs e)
        {

        }

        private void sendCommandButtonHandler(object sender, EventArgs e)
        {

        }
        #endregion Event Handlers

        private void listenForIncomingConnections()
        {
            try
            {
                keepWaiting = true;
                listener = new TcpListener(ipAddress, port);
                listener.Start();
            } catch (Exception ex)
            {

            }
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
