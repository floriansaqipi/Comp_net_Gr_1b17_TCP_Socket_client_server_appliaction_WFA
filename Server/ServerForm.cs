using Server.Utils;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class ServerForm : Form
    {
        //constants
        private const string CRLF = "\r\n";
        private const string FILES_PATH = "server_files/";

        //fields
        private List<TcpClient> clientList = new List<TcpClient>();
        private TcpListener listener;
        private int clientCount = 0;
        private bool keepWaiting;
        private IPAddress ipAddress = IPAddress.Parse("192.168.0.197");
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
            {   if(portTextBox.Text == string.Empty)
                {
                    port = 5000;
                    displayToTextBox("You entered no port number using port: " + port);
                }
                else if(!Int32.TryParse(portTextBox.Text, out port)
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
            if(clientCommandTextBox.Text == string.Empty)
            {
                displayToTextBox("Can not send empty string as a command.");
                return;
            }
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
            displayToTextBox("Broadcasting command: " + clientCommandTextBox.Text);
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
            connectedClientsTextBox.invokeEx(cctx => cctx.Text = clientCount.ToString());
            
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
                        case "CREATE_FILE":
                            {
                                string fileName = reader.ReadLine();
                                createFile(input, fileName, writer, client);
                                break;
                            }
                        case "DELETE_FILE":
                            {
                                string fileName = reader.ReadLine();
                                deleteFile(input, fileName, writer, client);
                                break;
                            }
                        case "GET_FILE_LIST":
                            {
                                sendFileList(input, writer, client);
                                break;
                            }
                        case "GET_FILE_CONTENT":
                            {
                                string fileName = reader.ReadLine();
                                sendFileContent(input, fileName, writer, client);
                                break;
                            }
                        case "WRITE_FILE_CONTENT":
                            {
                                string fileName = reader.ReadLine();
                                writeFileContent(input, fileName, writer, reader, client);
                                break;
                            }
                        case "EXECUTE_FILE":
                            {
                                string fileName = reader.ReadLine();
                                executeFile(input, fileName, writer, client);
                                break;
                            }
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
                handleExceptionInvoke("Client disconnected from server!", ex);
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

        private void createFile(string input, string fileName, StreamWriter clientResWriter, TcpClient client)
        {
            try
            {

                displayToTextBoxInvoke("From client " + client.GetHashCode() + ": " + input + " " + fileName);
                clientResWriter.WriteLine("Server received: " + input + " " + fileName);
                clientResWriter.Flush();
                StreamWriter writer = new StreamWriter(FILES_PATH + fileName);
                clientResWriter.WriteLine("Server created file: " + fileName);
                clientResWriter.Flush();
                writer.Close();
            }
            catch (IOException ioEx)
            {
                handleExceptionInvoke("Problem creating file: " + fileName, ioEx);
                clientResWriter.WriteLine("File : " + input + "could not be created");
                clientResWriter.Flush();
            }
        }

        private void deleteFile(string input, string fileName, StreamWriter clientResWriter, TcpClient client)
        {
            try
            {
                displayToTextBoxInvoke( "From client " + client.GetHashCode() + ": " + input + " " + fileName);
                clientResWriter.WriteLine("Server received: " + input + " " + fileName);
                clientResWriter.Flush();

                if (!File.Exists(FILES_PATH + fileName))
                {
                    clientResWriter.WriteLine("File: " + fileName + " can not be deleted, it does not exist!");
                    clientResWriter.Flush();
                    return;
                }
                File.Delete(FILES_PATH + fileName);
                clientResWriter.WriteLine("Server deleted file: " + fileName);
                clientResWriter.Flush();
            }
            catch (IOException ioEx)
            {
                handleExceptionInvoke("Problem deleting file: " + fileName,ioEx);
                clientResWriter.WriteLine("File : " + input + "could not be deleted");
                clientResWriter.Flush();
            }
        }

        private void sendFileList(string input, StreamWriter clientResWriter, TcpClient client)
        {
            try
            {
                displayToTextBoxInvoke("From client " + client.GetHashCode() + ": " + input);
                clientResWriter.WriteLine("Server received: " + input);
                clientResWriter.Flush();

                string[] files = Directory.GetFiles(FILES_PATH);

                clientResWriter.WriteLine("FILES_LIST_RES");
                clientResWriter.Flush();
                foreach (string file in files)
                {
                    clientResWriter.WriteLine(Path.GetFileName(file));
                    clientResWriter.Flush();
                }
                clientResWriter.WriteLine("END_OF_LIST");
                clientResWriter.Flush();
            }
            catch (Exception ex)
            {
                handleExceptionInvoke("Problem fetching files",ex);
                clientResWriter.WriteLine("Files could not be fetched");
                clientResWriter.Flush();
            }
        }

        private void sendFileContent(string input, string fileName, StreamWriter clientResWriter, TcpClient client)
        {
            try
            {
                displayToTextBoxInvoke("From client " + client.GetHashCode() + ": " + input);
                clientResWriter.WriteLine("Server received: " + input);
                clientResWriter.Flush();

                clientResWriter.WriteLine("FILE_CONTENT_RES");
                clientResWriter.Flush();
                clientResWriter.WriteLine(fileName);
                clientResWriter.Flush();

                StreamReader reader = new StreamReader(FILES_PATH + fileName);

                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    clientResWriter.WriteLine(line);
                    clientResWriter.Flush();
                }
                clientResWriter.WriteLine("END_OF_FILE");
                clientResWriter.Flush();
                reader.Close();

            }
            catch (Exception ex)
            {
                handleExceptionInvoke("Problem fetching file content", ex);
                clientResWriter.WriteLine("File content could not be fetched");
                clientResWriter.Flush();
            }
        }

        private void writeFileContent(string input, string fileName, StreamWriter clientResWriter, StreamReader clientReqReader, TcpClient client)
        {
            try
            {
                StreamWriter writer = new StreamWriter(FILES_PATH + fileName);
                displayToTextBoxInvoke( "From client " + client.GetHashCode() + ": " + input + " " + fileName);
                clientResWriter.WriteLine("Server received: " + input + " " + fileName);
                clientResWriter.Flush();

                string line = string.Empty;
                while ((line = clientReqReader.ReadLine()) != "END_OF_FILE")
                {
                    writer.WriteLine(line);
                    writer.Flush();
                }
                clientResWriter.WriteLine("Server updated file : " + fileName);
                clientResWriter.Flush();
                writer.Close();
            }
            catch (IOException ioEx)
            {
                handleExceptionInvoke("Problem creating file: " + fileName, ioEx);
                clientResWriter.WriteLine("File : " + input + "could not be written to.");
                clientResWriter.Flush();

            }
        }

        private void executeFile(string input, string fileName, StreamWriter clientResWriter, TcpClient client)
        {
            try
            {

                displayToTextBoxInvoke("From client " + client.GetHashCode() + ": " + input + " " + fileName);
                clientResWriter.WriteLine("Server received: " + input + " " + fileName);
                clientResWriter.Flush();


                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "server_files\\" + fileName,
                    UseShellExecute = true,
                };
                Process.Start(processStartInfo);

                clientResWriter.WriteLine("Server executed file: " + fileName);
                clientResWriter.Flush();
            }
            catch (Exception ex)
            {
                handleExceptionInvoke("Problem creating file: " + fileName, ex);

                clientResWriter.WriteLine("File : " + input + "could not be executed");
                clientResWriter.Flush();

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
