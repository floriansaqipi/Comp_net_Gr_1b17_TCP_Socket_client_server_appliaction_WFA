namespace Server
{
    partial class Form1
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
            tableLayoutPanel3 = new TableLayoutPanel();
            startServerButton = new Button();
            stopServerButton = new Button();
            portLabel = new Label();
            portTextBox = new TextBox();
            textBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(textBox, 0, 0);
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
            tableLayoutPanel2.Location = new Point(504, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel2.Size = new Size(289, 207);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
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
            tableLayoutPanel3.Location = new Point(504, 216);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 83.435585F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.5644169F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel3.Size = new Size(289, 207);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // startServerButton
            // 
            startServerButton.Location = new Point(147, 166);
            startServerButton.Name = "startServerButton";
            startServerButton.Size = new Size(139, 37);
            startServerButton.TabIndex = 0;
            startServerButton.Text = "Start Server";
            startServerButton.UseVisualStyleBackColor = true;
            startServerButton.Click += startServerButton_Click;
            // 
            // stopServerButton
            // 
            stopServerButton.Location = new Point(3, 166);
            stopServerButton.Name = "stopServerButton";
            stopServerButton.Size = new Size(138, 37);
            stopServerButton.TabIndex = 1;
            stopServerButton.Text = "Stop Server";
            stopServerButton.UseVisualStyleBackColor = true;
            stopServerButton.Click += stopServerButton_Click;
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
            portLabel.Click += portLabel_Click;
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
            portTextBox.TextChanged += portTextBox_TextChanged;
            // 
            // textBox
            // 
            textBox.Location = new Point(3, 3);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(textBox, 2);
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(495, 420);
            textBox.TabIndex = 2;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TextBox textBox;
        private Label portLabel;
        private TextBox portTextBox;
    }
}
