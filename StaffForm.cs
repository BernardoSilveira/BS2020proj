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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(StaffForm_FormClosed);

            dvgLibraryCollection.DataSource = Database.LibraryCollection;
        }

        private void StaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Serialize();
            Application.Exit();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            BindingList<User> WaitList = Database.FindClientInWait();
            DatabaseIndexes = Database.FindClientInWaitIndex();
            foreach (var user in WaitList)
            {
                string FullName = user.Name + " " + user.Surname;
                cmbClient.Items.Add(FullName);
            }
            ToggleButtons();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            IndClient = cmbClient.SelectedIndex;
            dvgReservedBooks.DataSource = Database.Users[DatabaseIndexes[IndClient]].ReservedBooks;
            dvgRentedBooks.DataSource = Database.Users[DatabaseIndexes[IndClient]].RentedBooks;
            ToggleButtons();
        }

        private int IndClient { get; set; } // Index of the List of clients waiting for pick-up.
        private List<int> DatabaseIndexes { get; set; } //Index of the Clients on the main database.
        private void btnRent_Click(object sender, EventArgs e)
        {
            Database.Rent(Database.Users[DatabaseIndexes[IndClient]], dvgReservedBooks.CurrentRow.DataBoundItem);
            (Database.Users[DatabaseIndexes[IndClient]] as Client).PickupReady = (dvgReservedBooks.Rows.Count > 0);
            ToggleButtons();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Database.Return(Database.Users[DatabaseIndexes[IndClient]], dvgRentedBooks.CurrentRow.DataBoundItem);
            btnReturn.Enabled = (dvgRentedBooks.Rows.Count > 0);
            ToggleButtons();
        }

        private void ToggleButtons()
        {
            btnReturn.Enabled = (dvgRentedBooks.Rows.Count > 0);
            btnRent.Enabled = (dvgReservedBooks.Rows.Count > 0);
        }
    }
}
