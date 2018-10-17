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
    public partial class label : Form
    {
        public label()
        {
            InitializeComponent();
            updateTime();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = null;
                string myConnection = "datasource=localhost;port=3306;username=root;pssword=;SslMode=none";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand($"select * from database.edata where username='{username_txt.Text}' AND password = '{password_txt.Text}';", myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    int id = myReader.GetInt32("id");
                    int age = myReader.GetInt32("age");
                    String name = myReader.GetString("name");
                    String surname = myReader.GetString("surname");
                    String username = myReader.GetString("username");
                    String password = myReader.GetString("password");

                    person = new Person(id, age, name, surname, username, password);

                    Console.WriteLine($"Zostal stoworzony obiekt typu person: {person}");
      
                    count++;
                }

                if (count == 1)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(person);
                    mainForm.ShowDialog();
                }
                else
                    MessageBox.Show("Not correct usernme or password");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm f2 = new RegisterForm();
            f2.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTime();
        }

        private void updateTime()
        {
            DateTime dateTime = DateTime.Now;
            TimeLabel.Text = dateTime.ToString();
        }
    }
}
