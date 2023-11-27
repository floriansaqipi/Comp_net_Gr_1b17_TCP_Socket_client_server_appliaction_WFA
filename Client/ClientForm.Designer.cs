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
            IPAddressTextBox = new TextBox();
            PortTextBox = new TextBox();
            IPAddress = new Label();
            PortLabel = new Label();
            connectButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
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
            tableLayoutPanel2.Controls.Add(IPAddressTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(PortTextBox, 1, 2);
            tableLayoutPanel2.Controls.Add(IPAddress, 0, 1);
            tableLayoutPanel2.Controls.Add(PortLabel, 0, 2);
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
            disconnectButton.Click += connectButtonHandler;
            // 
            // IPAddressTextBox
            // 
            IPAddressTextBox.Dock = DockStyle.Fill;
            IPAddressTextBox.Location = new Point(160, 97);
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.Size = new Size(151, 23);
            IPAddressTextBox.TabIndex = 4;
            IPAddressTextBox.Text = "127.0.0.1";
            IPAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PortTextBox
            // 
            PortTextBox.Dock = DockStyle.Fill;
            PortTextBox.Location = new Point(160, 128);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(151, 23);
            PortTextBox.TabIndex = 5;
            PortTextBox.Text = "5000";
            PortTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // IPAddress
            // 
            IPAddress.AutoSize = true;
            IPAddress.Dock = DockStyle.Fill;
            IPAddress.Location = new Point(3, 94);
            IPAddress.Name = "IPAddress";
            IPAddress.Size = new Size(151, 31);
            IPAddress.TabIndex = 2;
            IPAddress.Text = "IP Address:";
            IPAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PortLabel
            // 
            PortLabel.AutoSize = true;
            PortLabel.Dock = DockStyle.Fill;
            PortLabel.Location = new Point(3, 125);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(151, 32);
            PortLabel.TabIndex = 3;
            PortLabel.Text = "Port:";
            PortLabel.TextAlign = ContentAlignment.MiddleRight;
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
            tableLayoutPanel3.Controls.Add(sendCommandButton, 1, 2);
            tableLayoutPanel3.Controls.Add(commandTextBox, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(483, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 47.7419357F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 52.2580643F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel3.Size = new Size(314, 198);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // sendCommandButton
            // 
            sendCommandButton.Dock = DockStyle.Fill;
            sendCommandButton.Location = new Point(160, 162);
            sendCommandButton.Name = "sendCommandButton";
            sendCommandButton.Size = new Size(151, 33);
            sendCommandButton.TabIndex = 1;
            sendCommandButton.Text = "Send Command";
            sendCommandButton.UseVisualStyleBackColor = true;
            sendCommandButton.Click += sendCommandButtonHandler;
            // 
            // commandTextBox
            // 
            tableLayoutPanel3.SetColumnSpan(commandTextBox, 2);
            commandTextBox.Dock = DockStyle.Fill;
            commandTextBox.Location = new Point(3, 79);
            commandTextBox.Multiline = true;
            commandTextBox.Name = "commandTextBox";
            commandTextBox.Size = new Size(308, 77);
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
        private Label IPAddress;
        private Label PortLabel;
        private TextBox IPAddressTextBox;
        private TextBox PortTextBox;
        private Button sendCommandButton;
        private TextBox commandTextBox;
    }
}