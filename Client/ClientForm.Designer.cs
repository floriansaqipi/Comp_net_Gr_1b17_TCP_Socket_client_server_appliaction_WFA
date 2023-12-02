namespace Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            disconnectButton = new Button();
            ipAddressTextBox = new TextBox();
            portTextBox = new TextBox();
            ipAddressLabel = new Label();
            portLabel = new Label();
            connectButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            fileExplorerButton = new Button();
            sendCommandButton = new Button();
            commandTextBox = new TextBox();
            statusTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(statusTextBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 408);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(disconnectButton, 0, 3);
            tableLayoutPanel2.Controls.Add(ipAddressTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(portTextBox, 1, 2);
            tableLayoutPanel2.Controls.Add(ipAddressLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(portLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(connectButton, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(483, 207);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75.2F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(314, 198);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // disconnectButton
            // 
            disconnectButton.Dock = DockStyle.Fill;
            disconnectButton.Location = new Point(3, 160);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(151, 35);
            disconnectButton.TabIndex = 1;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = true;
            disconnectButton.Click += disconnectButtonHandler;
            // 
            // ipAddressTextBox
            // 
            ipAddressTextBox.Dock = DockStyle.Fill;
            ipAddressTextBox.Location = new Point(160, 97);
            ipAddressTextBox.Name = "ipAddressTextBox";
            ipAddressTextBox.Size = new Size(151, 23);
            ipAddressTextBox.TabIndex = 4;
            ipAddressTextBox.Text = "127.0.0.1";
            ipAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // portTextBox
            // 
            portTextBox.Dock = DockStyle.Fill;
            portTextBox.Location = new Point(160, 128);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(151, 23);
            portTextBox.TabIndex = 5;
            portTextBox.Text = "5000";
            portTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ipAddressLabel
            // 
            ipAddressLabel.AutoSize = true;
            ipAddressLabel.Dock = DockStyle.Fill;
            ipAddressLabel.Location = new Point(3, 94);
            ipAddressLabel.Name = "ipAddressLabel";
            ipAddressLabel.Size = new Size(151, 31);
            ipAddressLabel.TabIndex = 2;
            ipAddressLabel.Text = "IP Address:";
            ipAddressLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Dock = DockStyle.Fill;
            portLabel.Location = new Point(3, 125);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(151, 32);
            portLabel.TabIndex = 3;
            portLabel.Text = "Port:";
            portLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // connectButton
            // 
            connectButton.Dock = DockStyle.Fill;
            connectButton.Location = new Point(160, 160);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(151, 35);
            connectButton.TabIndex = 0;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButtonHandler;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(fileExplorerButton, 0, 3);
            tableLayoutPanel3.Controls.Add(sendCommandButton, 1, 2);
            tableLayoutPanel3.Controls.Add(commandTextBox, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(483, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 23.6220474F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 76.37795F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel3.Size = new Size(314, 198);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // fileExplorerButton
            // 
            tableLayoutPanel3.SetColumnSpan(fileExplorerButton, 2);
            fileExplorerButton.Dock = DockStyle.Fill;
            fileExplorerButton.Location = new Point(3, 158);
            fileExplorerButton.Name = "fileExplorerButton";
            fileExplorerButton.Size = new Size(308, 37);
            fileExplorerButton.TabIndex = 1;
            fileExplorerButton.Text = "Explore Files";
            fileExplorerButton.UseVisualStyleBackColor = true;
            fileExplorerButton.Click += fileExplorerButtonHandler;
            // 
            // sendCommandButton
            // 
            sendCommandButton.Dock = DockStyle.Fill;
            sendCommandButton.Location = new Point(160, 123);
            sendCommandButton.Name = "sendCommandButton";
            sendCommandButton.Size = new Size(151, 29);
            sendCommandButton.TabIndex = 1;
            sendCommandButton.Text = "Send Command";
            sendCommandButton.UseVisualStyleBackColor = true;
            sendCommandButton.Click += sendCommandButtonHandler;
            // 
            // commandTextBox
            // 
            tableLayoutPanel3.SetColumnSpan(commandTextBox, 2);
            commandTextBox.Dock = DockStyle.Fill;
            commandTextBox.Location = new Point(3, 31);
            commandTextBox.Multiline = true;
            commandTextBox.Name = "commandTextBox";
            commandTextBox.Size = new Size(308, 86);
            commandTextBox.TabIndex = 2;
            // 
            // statusTextBox
            // 
            statusTextBox.Dock = DockStyle.Fill;
            statusTextBox.Location = new Point(3, 3);
            statusTextBox.Multiline = true;
            statusTextBox.Name = "statusTextBox";
            tableLayoutPanel1.SetRowSpan(statusTextBox, 2);
            statusTextBox.ScrollBars = ScrollBars.Vertical;
            statusTextBox.Size = new Size(474, 402);
            statusTextBox.TabIndex = 2;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 408);
            Controls.Add(tableLayoutPanel1);
            Name = "ClientForm";
            Text = "ClientForm";
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
        private TextBox statusTextBox;
        private Button connectButton;
        private Button disconnectButton;
        private Label ipAddressLabel;
        private Label portLabel;
        private TextBox ipAddressTextBox;
        private TextBox portTextBox;
        private Button sendCommandButton;
        private TextBox commandTextBox;
        private Button fileExplorerButton;
    }
}