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
            cmbLogin.Items.Add("Client"); //The default client for example purposes will be the client with name "Client Cliento"
            cmbLogin.Items.Add("Staff Member"); //The Default staff member for exemple purposes will be "Staff Staffo"
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int indUser = cmbLogin.SelectedIndex; //simulating login
            switch (indUser)
            {
                case 0:
                    ClientForm newClientForm = new ClientForm(indUser);
                    newClientForm.Show();
                    this.Hide();
                    break;
                case 1:
                    StaffForm newStaffForm = new StaffForm();
                    newStaffForm.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
