using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
