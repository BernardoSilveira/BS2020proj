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
    public partial class ClientForm : Form
    {
        public ClientForm(int indclient)
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(ClientForm_FormClosed);

            string clientFullName = Database.Users[indclient].Name + " " + Database.Users[indclient].Surname;
            clientLabel.Text = clientFullName;

            dvgLibraryCollection.DataSource = Database.LibraryCollection;
        }
        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
