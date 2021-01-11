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
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            IndClient = cmbClient.SelectedIndex;
            dvgReservedBooks.DataSource = Database.Users[DatabaseIndexes[IndClient]].ReservedBooks;
            dvgRentedBooks.DataSource = Database.Users[DatabaseIndexes[IndClient]].RentedBooks;
        }

        private int IndClient { get; set; }
        private List<int> DatabaseIndexes { get; set; }
        private void btnRent_Click(object sender, EventArgs e)
        {
            Database.Rent(Database.Users[DatabaseIndexes[IndClient]], dvgReservedBooks.CurrentRow.DataBoundItem);
            if(dvgReservedBooks.Rows.Count < 1)
            {
                (Database.Users[DatabaseIndexes[IndClient]] as Client).PickupReady = false;
                btnRent.Enabled = false;
            } else
            {
                btnRent.Enabled = true;
            }
        }
    }
}
