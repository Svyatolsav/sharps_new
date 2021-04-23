using System;
using System.Windows.Forms;
using Task4_ClassLibrary;

namespace Task4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PC1Create_Click(object sender, EventArgs e)
        {
            PrintInfo(new Computer1(Processor1.Text, int.Parse(MHZ1.Text), int.Parse(RAM1.Text)));
        }

        private void PC2Create_Click(object sender, EventArgs e)
        {
            PrintInfo(new Computer2(Processor2.Text, int.Parse(MHZ2.Text), int.Parse(RAM2.Text), int.Parse(HDD.Text)));
        }

        private void PrintInfo(Computer1 pc)
        {
            Info.Text = pc.ToString();
        }
    }
}
