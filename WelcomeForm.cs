using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BS2020proj
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            comboLogin.Items.Add("Client"); //The default client for example purposes will be the client with name "User User"
            comboLogin.Items.Add("Staff Member");
            //comboLogin.Items.Add("Manager");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboLogin.SelectedIndex)
            {
                case 0:
                    ClientForm newClientForm = new ClientForm();
                    newClientForm.Show();
                    this.Hide();
                    break;
                case 1:
                    StaffForm newStaffForm = new StaffForm();
                    newStaffForm.Show();
                    this.Hide();
                    break;
               /* case 2:
                    this.Hide();
                    ClientForm newClientForm = new ClientForm();
                    newClientForm.Show();
                    break;*/
            }
        }
    }
}
