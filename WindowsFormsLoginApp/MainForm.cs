using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsLoginApp
{
    public partial class MainForm : Form
    {
        Person person;
        public MainForm()
        {
            InitializeComponent();
        }
        
        public MainForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            this.dataLabel.Text = $"Witaj {person.Name} {person.Surname}. Masz {person.Age} lat.";
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(person);
            editForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;pssword=;SslMode=none";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                String query = $"DELETE FROM database.edata WHERE id={person.Id};";
                MySqlCommand cmd = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Deleted");
                myConn.Close();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chellenge = ChellengeTextBox.Text;
            ChellengeComboBox.Items.Add(chellenge);
            ChellengeListBox.Items.Add(chellenge);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowUsersForm showUsersForm = new ShowUsersForm();
            showUsersForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure exit?", "Are you?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
            
        }
    }
}
