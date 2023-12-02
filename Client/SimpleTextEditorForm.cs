using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class SimpleTextEditorForm : Form
    {
        //Constants
        private const string CRLF = "\r\n";

        //Fields
        private List<string> fileLines = new List<string>();
        public SimpleTextEditorForm()
        {
            InitializeComponent();
        }

        private void onLoadForm(object sender, EventArgs e)
        {
            fileContentRichTextBox.Text = string.Empty;
            foreach (string line in fileLines)
            {
                fileContentRichTextBox.Text += line + CRLF;
            }
        }

        private void fontMenuItemClickHandler(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            fileContentRichTextBox.SelectionFont = fontDialog.Font;
        }
        private void colorMenuItemClickHandler(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            fileContentRichTextBox.SelectionColor = colorDialog.Color;
        }

        public List<string> FileLines
        {
            get { return fileLines; }
            set { fileLines = value; }
        }

    }
}
