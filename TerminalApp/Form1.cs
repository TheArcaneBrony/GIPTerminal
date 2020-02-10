using Database.Acces;
using Database.MySQL;
using System;
using System.Windows.Forms;

namespace TerminalApp
{
    public partial class Form1 : Form
    {
        AccesConnection access = AccesConnection.Connect();
        MySQLConnection mysql = MySQLConnection.Connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Database nicknames for workshops
        private readonly protected string[] wsid = new string[] { "NULL", "VR", "GD", "CODE", "PC" };
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string
                WS1Code = wsid[Ws1CBox.SelectedIndex],
                WS2Code = wsid[Ws1CBox.SelectedIndex],
                Name = NameTBox.Text,
                LastName = LastNameTBox.Text;

            access.Insert(Name, LastName, WS1Code, WS2Code);
            MessageBox.Show($"Goede avond {Name} {LastName}!\n\nU selecteerde {((Label)Ws1CBox.SelectedItem).Text}", "Confirmatie", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        }
    }
}
