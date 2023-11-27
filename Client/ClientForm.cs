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
        //TODO: Fisnik Hazrolli - add constants here like CRLF, LOCALHOST, DEFAULT PORT

        //Constants

        //TODO: Fisnik Hazrolli - add fields here serverIp, port, client 

        // Fields


        //TODO: Fisnik Hazrolli - initialize necessary components here in the constructor
        public ClientForm()
        {
            InitializeComponent();
        }


        #region Event Handlers
        
        //TODO: Florian Saqipi - implement this 
        private void connectButtonHandler(object sender, EventArgs e)
        {

        }

        //TODO: Fjolla Ajeti - implement this 
        private void disconnectButtonHandler(object sender, EventArgs e) 
        {
        
        }
        //TODO: Fisnik Hazrolli - implement this
        private void sendCommandButtonHandler(object sender, EventArgs e)
        {

        }
        #endregion Event Handlers


        private void processClientTransactions(object tcpClient)
        {

        }

        //TODO: Fjolla Ajeti - implement this
        private void disconnectFromServer()
        {

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
