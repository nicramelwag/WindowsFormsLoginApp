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
    public partial class EditForm : Form
    {

        public Person MyPerson {get; private set; }

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Person person)
        {
            MyPerson = person;
            InitializeComponent();
            NameTxt.Text = MyPerson.Name;
            SurnameTxt.Text = MyPerson.Surname;
            AgeTxt.Text = Convert.ToString(MyPerson.Age);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;pssword=;SslMode=none";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                String query = $"UPDATE database.edata SET name ='{NameTxt.Text}', surname = '{SurnameTxt.Text}', age ={AgeTxt.Text} WHERE id={MyPerson.Id};";
                MySqlCommand cmd = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Saved");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
