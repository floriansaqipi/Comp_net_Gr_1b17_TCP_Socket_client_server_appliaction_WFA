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
            DisconnectButton = new Button();
            IPAddressTextBox = new TextBox();
            PortTextBox = new TextBox();
            IPAddress = new Label();
            PortLabel = new Label();
            ConnectButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            Sendbutton = new Button();
            CommendtextBox = new TextBox();
            staticTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(staticTextBox, 0, 0);
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
            tableLayoutPanel2.Controls.Add(DisconnectButton, 0, 3);
            tableLayoutPanel2.Controls.Add(IPAddressTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(PortTextBox, 1, 2);
            tableLayoutPanel2.Controls.Add(IPAddress, 0, 1);
            tableLayoutPanel2.Controls.Add(PortLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(ConnectButton, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(403, 207);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 81.30081F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6991863F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.Size = new Size(394, 198);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // DisconnectButton
            // 
            DisconnectButton.Dock = DockStyle.Fill;
            DisconnectButton.Location = new Point(3, 160);
            DisconnectButton.Name = "DisconnectButton";
            DisconnectButton.Size = new Size(191, 35);
            DisconnectButton.TabIndex = 1;
            DisconnectButton.Text = "Disconnect";
            DisconnectButton.UseVisualStyleBackColor = true;
            // 
            // IPAddressTextBox
            // 
            IPAddressTextBox.Dock = DockStyle.Fill;
            IPAddressTextBox.Location = new Point(200, 103);
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.Size = new Size(191, 23);
            IPAddressTextBox.TabIndex = 4;
            IPAddressTextBox.Text = "127.0.0.1";
            IPAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PortTextBox
            // 
            PortTextBox.Dock = DockStyle.Fill;
            PortTextBox.Location = new Point(200, 126);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(191, 23);
            PortTextBox.TabIndex = 5;
            PortTextBox.Text = "5000";
            PortTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // IPAddress
            // 
            IPAddress.AutoSize = true;
            IPAddress.Dock = DockStyle.Fill;
            IPAddress.Location = new Point(3, 100);
            IPAddress.Name = "IPAddress";
            IPAddress.Size = new Size(191, 23);
            IPAddress.TabIndex = 2;
            IPAddress.Text = "IP Address:";
            IPAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PortLabel
            // 
            PortLabel.AutoSize = true;
            PortLabel.Dock = DockStyle.Fill;
            PortLabel.Location = new Point(3, 123);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(191, 34);
            PortLabel.TabIndex = 3;
            PortLabel.Text = "Port:";
            PortLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ConnectButton
            // 
            ConnectButton.Dock = DockStyle.Fill;
            ConnectButton.Location = new Point(200, 160);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(191, 35);
            ConnectButton.TabIndex = 0;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(Sendbutton, 1, 2);
            tableLayoutPanel3.Controls.Add(CommendtextBox, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(403, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 59.375F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40.625F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.Size = new Size(394, 198);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // Sendbutton
            // 
            Sendbutton.Dock = DockStyle.Fill;
            Sendbutton.Location = new Point(200, 147);
            Sendbutton.Name = "Sendbutton";
            Sendbutton.Size = new Size(191, 48);
            Sendbutton.TabIndex = 1;
            Sendbutton.Text = "Send";
            Sendbutton.UseVisualStyleBackColor = true;
            // 
            // CommendtextBox
            // 
            tableLayoutPanel3.SetColumnSpan(CommendtextBox, 2);
            CommendtextBox.Dock = DockStyle.Fill;
            CommendtextBox.Location = new Point(3, 89);
            CommendtextBox.Multiline = true;
            CommendtextBox.Name = "CommendtextBox";
            CommendtextBox.Size = new Size(388, 52);
            CommendtextBox.TabIndex = 2;
            // 
            // staticTextBox
            // 
            staticTextBox.Dock = DockStyle.Fill;
            staticTextBox.Location = new Point(3, 3);
            staticTextBox.Multiline = true;
            staticTextBox.Name = "staticTextBox";
            tableLayoutPanel1.SetRowSpan(staticTextBox, 2);
            staticTextBox.ScrollBars = ScrollBars.Vertical;
            staticTextBox.Size = new Size(394, 402);
            staticTextBox.TabIndex = 2;
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
        private TextBox staticTextBox;
        private Button ConnectButton;
        private Button DisconnectButton;
        private Label IPAddress;
        private Label PortLabel;
        private TextBox IPAddressTextBox;
        private TextBox PortTextBox;
        private Button Sendbutton;
        private TextBox CommendtextBox;
    }
}