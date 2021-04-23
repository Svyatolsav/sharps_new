using Task3_ClassLibrary;
using System;
using System.Windows.Forms;

namespace Task3
{
    public partial class MainForm : Form
    {
        private static Text TextObject = new Text("");

        public MainForm()
        {
            InitializeComponent();
        }

        private void AppendBtn_Click(object sender, EventArgs e)
        {
            TextObject.AppendText(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            Text.Text = TextObject.PrintText();
        }

        private void HeaderBtn_Click(object sender, EventArgs e)
        {
            Header.Text = TextObject.TextHeader();
        }
    }
}
