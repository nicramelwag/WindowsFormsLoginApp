﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;pssword=;SslMode=none";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand cmd = new MySqlCommand($"insert into database.edata (name, surname, age, username, password) values('{NameTxt.Text}', '{SurnameTxt.Text}', {AgeTxt.Text}, '{UsernameTxt.Text}', '{PasswordTxt.Text}');", myConn);

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
