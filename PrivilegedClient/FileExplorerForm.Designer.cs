namespace PrivilegedClient
{
    partial class FileExplorerForm
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            executeFileButton = new Button();
            openFileButton = new Button();
            fileListView = new ListView();
            fileNames = new ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(504, 42);
            label1.TabIndex = 0;
            label1.Text = "Select a file";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(fileListView, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.434783F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.5652161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(510, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.5814F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.4186039F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel2.Controls.Add(executeFileButton, 2, 0);
            tableLayoutPanel2.Controls.Add(openFileButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 410);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(504, 37);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // executeFileButton
            // 
            executeFileButton.Dock = DockStyle.Fill;
            executeFileButton.Location = new Point(407, 3);
            executeFileButton.Name = "executeFileButton";
            executeFileButton.Size = new Size(94, 31);
            executeFileButton.TabIndex = 2;
            executeFileButton.Text = "Execute File";
            executeFileButton.UseVisualStyleBackColor = true;
            // 
            // openFileButton
            // 
            openFileButton.Dock = DockStyle.Fill;
            openFileButton.Location = new Point(309, 3);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(92, 31);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "Open File";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButtonHandler;
            // 
            // fileListView
            // 
            fileListView.Columns.AddRange(new ColumnHeader[] { fileNames });
            fileListView.Dock = DockStyle.Fill;
            fileListView.GridLines = true;
            fileListView.Location = new Point(3, 45);
            fileListView.MultiSelect = false;
            fileListView.Name = "fileListView";
            fileListView.Size = new Size(504, 359);
            fileListView.TabIndex = 1;
            fileListView.UseCompatibleStateImageBehavior = false;
            fileListView.View = View.Details;
            fileListView.Click += listViewClickHandler;
            // 
            // fileNames
            // 
            fileNames.Text = "File Names";
            fileNames.Width = 500;
            // 
            // FileExplorerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FileExplorerForm";
            Text = "FileExplorerForm";
            Load += onFormLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button executeFileButton;
        private Button openFileButton;
        private ListView fileListView;
        private ColumnHeader fileNames;
    }
}