using System;
using System.IO;
using System.Windows.Forms;
using Task2_ClassLibrary;

namespace Task2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            if (this.FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.WorkingPath.Text = this.FolderBrowserDialog.SelectedPath;
                this.Input.Text = Path.Combine(this.WorkingPath.Text, "Input.txt");
                this.Output.Text = Path.Combine(this.WorkingPath.Text, "Output.txt");
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var solver = new Task2Solver()
            {
                Input = this.Input.Text,
                N = Int32.Parse(this.InputN.Text),
                Output = this.Output.Text
            };
            solver.Extract();
        }
    }
}
