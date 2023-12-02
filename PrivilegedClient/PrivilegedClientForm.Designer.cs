namespace PrivilegedClient
{
    partial class PrivilegedClientForm
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
            disconnectButton = new Button();
            ipAddressLabel = new Label();
            portTextBox = new TextBox();
            sendCommandButton = new Button();
            commandTextBox = new TextBox();
            createFileNameTextBox = new TextBox();
            createFileButton = new Button();
            fileNameLabel = new Label();
            deleteFileButton = new Button();
            portLabel = new Label();
            connectButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            ipAddressTextBox = new TextBox();
            deleteFileNameLabel = new Label();
            deleteFileNameTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            fileExplorerButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            statusTextBox = new TextBox();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // disconnectButton
            // 
            disconnectButton.Dock = DockStyle.Fill;
            disconnectButton.Location = new Point(3, 120);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(149, 32);
            disconnectButton.TabIndex = 1;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = true;
            disconnectButton.Click += disconnectButtonHandler;
            // 
            // ipAddressLabel
            // 
            ipAddressLabel.AutoSize = true;
            ipAddressLabel.Dock = DockStyle.Fill;
            ipAddressLabel.Location = new Point(3, 60);
            ipAddressLabel.Name = "ipAddressLabel";
            ipAddressLabel.Size = new Size(149, 29);
            ipAddressLabel.TabIndex = 2;
            ipAddressLabel.Text = "Ip Address:";
            ipAddressLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // portTextBox
            // 
            portTextBox.Dock = DockStyle.Fill;
            portTextBox.Location = new Point(158, 92);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(150, 23);
            portTextBox.TabIndex = 5;
            portTextBox.Text = "5000";
            portTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // sendCommandButton
            // 
            sendCommandButton.Dock = DockStyle.Fill;
            sendCommandButton.Location = new Point(158, 80);
            sendCommandButton.Name = "sendCommandButton";
            sendCommandButton.Size = new Size(150, 31);
            sendCommandButton.TabIndex = 6;
            sendCommandButton.Text = "Send Command";
            sendCommandButton.UseVisualStyleBackColor = true;
            sendCommandButton.Click += sendCommandButtonHandler;
            // 
            // commandTextBox
            // 
            tableLayoutPanel2.SetColumnSpan(commandTextBox, 2);
            commandTextBox.Dock = DockStyle.Fill;
            commandTextBox.Location = new Point(3, 21);
            commandTextBox.Multiline = true;
            commandTextBox.Name = "commandTextBox";
            commandTextBox.Size = new Size(305, 53);
            commandTextBox.TabIndex = 7;
            // 
            // createFileNameTextBox
            // 
            createFileNameTextBox.Dock = DockStyle.Fill;
            createFileNameTextBox.Location = new Point(158, 117);
            createFileNameTextBox.Name = "createFileNameTextBox";
            createFileNameTextBox.Size = new Size(150, 23);
            createFileNameTextBox.TabIndex = 8;
            createFileNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // createFileButton
            // 
            createFileButton.Dock = DockStyle.Fill;
            createFileButton.Location = new Point(158, 145);
            createFileButton.Name = "createFileButton";
            createFileButton.Size = new Size(150, 30);
            createFileButton.TabIndex = 9;
            createFileButton.Text = "Create File";
            createFileButton.UseVisualStyleBackColor = true;
            createFileButton.Click += createFileButtonHandler;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Dock = DockStyle.Fill;
            fileNameLabel.Location = new Point(3, 114);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(149, 28);
            fileNameLabel.TabIndex = 10;
            fileNameLabel.Text = "File Name:";
            fileNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deleteFileButton
            // 
            deleteFileButton.Dock = DockStyle.Fill;
            deleteFileButton.Location = new Point(158, 210);
            deleteFileButton.Name = "deleteFileButton";
            deleteFileButton.Size = new Size(150, 26);
            deleteFileButton.TabIndex = 11;
            deleteFileButton.Text = "Delete File";
            deleteFileButton.UseVisualStyleBackColor = true;
            deleteFileButton.Click += deleteFileButtonHandler;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Dock = DockStyle.Fill;
            portLabel.Location = new Point(3, 89);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(149, 28);
            portLabel.TabIndex = 1;
            portLabel.Text = "Port:";
            portLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // connectButton
            // 
            connectButton.Dock = DockStyle.Fill;
            connectButton.Location = new Point(158, 120);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(150, 32);
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
            tableLayoutPanel3.Controls.Add(portLabel, 0, 2);
            tableLayoutPanel3.Controls.Add(connectButton, 1, 3);
            tableLayoutPanel3.Controls.Add(disconnectButton, 0, 3);
            tableLayoutPanel3.Controls.Add(ipAddressLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(ipAddressTextBox, 1, 1);
            tableLayoutPanel3.Controls.Add(portTextBox, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(486, 292);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 67.41573F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 32.58427F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.Size = new Size(311, 155);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // ipAddressTextBox
            // 
            ipAddressTextBox.Dock = DockStyle.Fill;
            ipAddressTextBox.Location = new Point(158, 63);
            ipAddressTextBox.Name = "ipAddressTextBox";
            ipAddressTextBox.Size = new Size(150, 23);
            ipAddressTextBox.TabIndex = 4;
            ipAddressTextBox.Text = "127.0.0.1";
            ipAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // deleteFileNameLabel
            // 
            deleteFileNameLabel.AutoSize = true;
            deleteFileNameLabel.Dock = DockStyle.Fill;
            deleteFileNameLabel.Location = new Point(3, 178);
            deleteFileNameLabel.Name = "deleteFileNameLabel";
            deleteFileNameLabel.Size = new Size(149, 29);
            deleteFileNameLabel.TabIndex = 12;
            deleteFileNameLabel.Text = "File Name:";
            deleteFileNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deleteFileNameTextBox
            // 
            deleteFileNameTextBox.Dock = DockStyle.Fill;
            deleteFileNameTextBox.Location = new Point(158, 181);
            deleteFileNameTextBox.Name = "deleteFileNameTextBox";
            deleteFileNameTextBox.Size = new Size(150, 23);
            deleteFileNameTextBox.TabIndex = 13;
            deleteFileNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.83923F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.16077F));
            tableLayoutPanel2.Controls.Add(sendCommandButton, 1, 2);
            tableLayoutPanel2.Controls.Add(commandTextBox, 0, 1);
            tableLayoutPanel2.Controls.Add(createFileNameTextBox, 1, 3);
            tableLayoutPanel2.Controls.Add(createFileButton, 1, 4);
            tableLayoutPanel2.Controls.Add(fileNameLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(deleteFileButton, 1, 6);
            tableLayoutPanel2.Controls.Add(deleteFileNameLabel, 0, 5);
            tableLayoutPanel2.Controls.Add(deleteFileNameTextBox, 1, 5);
            tableLayoutPanel2.Controls.Add(fileExplorerButton, 0, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(486, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.287672F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 76.712326F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.Size = new Size(311, 283);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // fileExplorerButton
            // 
            tableLayoutPanel2.SetColumnSpan(fileExplorerButton, 2);
            fileExplorerButton.Dock = DockStyle.Fill;
            fileExplorerButton.Location = new Point(3, 242);
            fileExplorerButton.Name = "fileExplorerButton";
            fileExplorerButton.Size = new Size(305, 38);
            fileExplorerButton.TabIndex = 14;
            fileExplorerButton.Text = "File Explorer";
            fileExplorerButton.UseVisualStyleBackColor = true;
            fileExplorerButton.Click += fileExplorerButtonHandler;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.625F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(statusTextBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.22222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.77778F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(3, 3);
            statusTextBox.Multiline = true;
            statusTextBox.Name = "statusTextBox";
            statusTextBox.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(statusTextBox, 2);
            statusTextBox.ScrollBars = ScrollBars.Vertical;
            statusTextBox.Size = new Size(477, 444);
            statusTextBox.TabIndex = 2;
            // 
            // PrivilegedClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PrivilegedClientForm";
            Text = "PrivilegedClientForm";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button disconnectButton;
        private Label ipAddressLabel;
        private TextBox portTextBox;
        private Button sendCommandButton;
        private TextBox commandTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox createFileNameTextBox;
        private Button createFileButton;
        private Label fileNameLabel;
        private Button deleteFileButton;
        private Label deleteFileNameLabel;
        private TextBox deleteFileNameTextBox;
        private Button fileExplorerButton;
        private Label portLabel;
        private Button connectButton;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox ipAddressTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox statusTextBox;
    }
}