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
            dvgReservedBooks.DataSource = Database.Users[indclient].ReservedBooks;
            dvgRentedBooks.DataSource = Database.Users[indclient].RentedBooks;
            IndClient = indclient;
            
        }
        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            (Database.Users[IndClient] as Client).PickupReady = true;
            MessageBox.Show("Your Books are ready for pick-up.");
        }

        private int IndClient { get; set; }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Database.Reserve(Database.Users[IndClient], dvgLibraryCollection.CurrentRow.DataBoundItem);

            btnReserve.Enabled = (dvgLibraryCollection.Rows.Count > 0);
        }
    }
}
