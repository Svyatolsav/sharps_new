using System;
using System.ComponentModel;
using System.Windows.Forms;
using Task6_ClassLibrary;

namespace Task6
{
    public partial class MainForm : Form
    {
        readonly IBindingList source = new BindingList<Encyclopedia>();

        public MainForm()
        {
            InitializeComponent();
            sources.AutoGenerateColumns = true;
            sources.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var encyclopedia = new Encyclopedia
            {
                EncyclopediaType = rb1.Checked ? "Справочник" : "Энциклопедия",
                EncyclopediaGenre = EncyclopediaGenre.Text,
                Name = NameField.Text,
                Date = Date.Text,
                Raiting = Raiting.Text,
            };

            source.Add(encyclopedia);

            EncyclopediaGenre.Text = NameField.Text = Date.Text = Raiting.Text = "";
        }
    }
}
