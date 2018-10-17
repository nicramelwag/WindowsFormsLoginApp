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
    public partial class ShowUsersForm : Form
    {
        public ShowUsersForm()
        {
            InitializeComponent();
            loadData();
            loadChart();
        }

        private void loadData()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;pssword=;SslMode=none";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = $"select id, name, surname, age from database.edata;";

                MySqlCommand SelectCommand = new MySqlCommand(query, myConn);

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = SelectCommand;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();

                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;
                mySqlDataAdapter.Update(dataTable);

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadChart()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;pssword=;SslMode=none";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = $"select name, surname, age from database.edata;";

                MySqlCommand myCommand = new MySqlCommand(query, myConn);

                MySqlDataReader reader;

                myConn.Open();
                reader = myCommand.ExecuteReader();

                while(reader.Read())
                {
                    chart1.Series["Age"].Points.AddXY($"{reader.GetString("name")} {reader.GetString("surname")}", reader.GetInt32("age"));
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
