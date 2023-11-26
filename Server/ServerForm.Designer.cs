namespace Server
{
    partial class ServerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelConnectedClients = new Label();
            connectedClientsTextBox = new TextBox();
            sendCommandButton = new Button();
            textBoxClientCommand = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            startServerButton = new Button();
            stopServerButton = new Button();
            portLabel = new Label();
            portTextBox = new TextBox();
            statusTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.9396973F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.0603027F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(statusTextBox, 0, 0);
            tableLayoutPanel1.Location = new Point(2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(796, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17301F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82699F));
            tableLayoutPanel2.Controls.Add(labelConnectedClients, 0, 0);
            tableLayoutPanel2.Controls.Add(connectedClientsTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(sendCommandButton, 1, 3);
            tableLayoutPanel2.Controls.Add(textBoxClientCommand, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(504, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.2135925F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 73.78641F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.Size = new Size(289, 207);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelConnectedClients
            // 
            labelConnectedClients.AutoSize = true;
            labelConnectedClients.Dock = DockStyle.Fill;
            labelConnectedClients.Location = new Point(3, 0);
            labelConnectedClients.Name = "labelConnectedClients";
            labelConnectedClients.Size = new Size(139, 27);
            labelConnectedClients.TabIndex = 0;
            labelConnectedClients.Text = "Connected Clients:";
            labelConnectedClients.TextAlign = ContentAlignment.MiddleRight;
            // 
            // connectedClientsTextBox
            // 
            connectedClientsTextBox.Dock = DockStyle.Fill;
            connectedClientsTextBox.Location = new Point(148, 3);
            connectedClientsTextBox.Name = "connectedClientsTextBox";
            connectedClientsTextBox.Size = new Size(138, 23);
            connectedClientsTextBox.TabIndex = 1;
            connectedClientsTextBox.Text = "0";
            connectedClientsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // sendCommandButton
            // 
            sendCommandButton.Dock = DockStyle.Fill;
            sendCommandButton.Location = new Point(148, 176);
            sendCommandButton.Name = "sendCommandButton";
            sendCommandButton.Size = new Size(138, 28);
            sendCommandButton.TabIndex = 2;
            sendCommandButton.Text = "Send Command";
            sendCommandButton.UseVisualStyleBackColor = true;
            sendCommandButton.Click += sendCommandButtonHandler;
            // 
            // textBoxClientCommand
            // 
            tableLayoutPanel2.SetColumnSpan(textBoxClientCommand, 2);
            textBoxClientCommand.Dock = DockStyle.Fill;
            textBoxClientCommand.Location = new Point(3, 106);
            textBoxClientCommand.Multiline = true;
            textBoxClientCommand.Name = "textBoxClientCommand";
            textBoxClientCommand.Size = new Size(283, 64);
            textBoxClientCommand.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(startServerButton, 1, 2);
            tableLayoutPanel3.Controls.Add(stopServerButton, 0, 2);
            tableLayoutPanel3.Controls.Add(portLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(portTextBox, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(504, 216);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 83.435585F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.5644169F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel3.Size = new Size(289, 207);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // startServerButton
            // 
            startServerButton.Dock = DockStyle.Fill;
            startServerButton.Location = new Point(147, 166);
            startServerButton.Name = "startServerButton";
            startServerButton.Size = new Size(139, 38);
            startServerButton.TabIndex = 0;
            startServerButton.Text = "Start Server";
            startServerButton.UseVisualStyleBackColor = true;
            startServerButton.Click += startServerButtonHandler;
            // 
            // stopServerButton
            // 
            stopServerButton.Dock = DockStyle.Fill;
            stopServerButton.Location = new Point(3, 166);
            stopServerButton.Name = "stopServerButton";
            stopServerButton.Size = new Size(138, 38);
            stopServerButton.TabIndex = 1;
            stopServerButton.Text = "Stop Server";
            stopServerButton.UseVisualStyleBackColor = true;
            stopServerButton.Click += stopServerButtonHandler;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Dock = DockStyle.Fill;
            portLabel.Location = new Point(3, 136);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(138, 27);
            portLabel.TabIndex = 2;
            portLabel.Text = "Listen on port:";
            portLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // portTextBox
            // 
            portTextBox.Dock = DockStyle.Fill;
            portTextBox.Location = new Point(147, 139);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(139, 23);
            portTextBox.TabIndex = 3;
            portTextBox.Text = "5000";
            portTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // statusTextBox
            // 
            statusTextBox.Dock = DockStyle.Fill;
            statusTextBox.Location = new Point(3, 3);
            statusTextBox.Multiline = true;
            statusTextBox.Name = "statusTextBox";
            statusTextBox.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(statusTextBox, 2);
            statusTextBox.ScrollBars = ScrollBars.Vertical;
            statusTextBox.Size = new Size(495, 420);
            statusTextBox.TabIndex = 2;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ServerForm";
            Text = "WinForm Server";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button startServerButton;
        private Button stopServerButton;
        private TextBox statusTextBox;
        private Label portLabel;
        private TextBox portTextBox;
        private Label labelConnectedClients;
        private TextBox connectedClientsTextBox;
        private Button sendCommandButton;
        private TextBox textBoxClientCommand;
    }
}
