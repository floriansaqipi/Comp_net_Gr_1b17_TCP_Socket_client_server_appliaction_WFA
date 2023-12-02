namespace Client
{
    partial class SimpleTextEditorForm
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
            menuStrip1 = new MenuStrip();
            fontToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem1 = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            fileContentRichTextBox = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fontToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem1, colorToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(43, 20);
            fontToolStripMenuItem.Text = "Font";
            // 
            // fontToolStripMenuItem1
            // 
            fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            fontToolStripMenuItem1.Size = new Size(180, 22);
            fontToolStripMenuItem1.Text = "Font";
            fontToolStripMenuItem1.Click += fontMenuItemClickHandler;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorMenuItemClickHandler;
            // 
            // fileContentRichTextBox
            // 
            fileContentRichTextBox.Dock = DockStyle.Fill;
            fileContentRichTextBox.Location = new Point(3, 35);
            fileContentRichTextBox.Name = "fileContentRichTextBox";
            fileContentRichTextBox.ReadOnly = true;
            fileContentRichTextBox.Size = new Size(794, 412);
            fileContentRichTextBox.TabIndex = 1;
            fileContentRichTextBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(fileContentRichTextBox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.26392269F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.73608F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // SimpleTextEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "SimpleTextEditorForm";
            Text = "SimpleTextEditorForm";
            Load += onLoadForm;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem1;
        private ToolStripMenuItem colorToolStripMenuItem;
        private RichTextBox fileContentRichTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
    }
}