using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS2020proj
{
    public static class Database
    {
        public static BindingList<User> Users { get; private set; } = new BindingList<User>();
        public static BindingList<Book> LibraryCollection { get; private set; } = new BindingList<Book>();

        static Database()
        {
            DateTime date1 = new DateTime(1982, 08, 12);
            User u = new Client("Client", "Cliento", "Brambova 45", date1);
            Users.Add(u);
            Users.Add(new Staff("Staff", "Staffo", "Brambova 45", date1, Positions.Manager));
            Users.Add(new Client("John", "Adams", "Nasdrova 32", date1));
            Users.Add(new Client("David", "Destro", "Olova 65", date1));
            Users.Add(new Staff("Maria", "Staffova", "Brambova 45", date1, Positions.ClientService));
            Users.Add(new Client("Marc", "David", "Bluova 90", date1));
            u.ReservedBooks.Add(new Book("The Shinning6", "Stephen King", "Horror"));
            u.RentedBooks.Add(new Book("The Shinning7", "Stephen King", "Horror"));

            LibraryCollection.Add(new Book("The Shinning", "Stephen King", "Horror"));
            LibraryCollection.Add(new Book("The Shinning1", "Stephen King", "Horror"));
            LibraryCollection.Add(new Book("The Shinning2", "Stephen King", "Horror"));
            LibraryCollection.Add(new Book("The Shinning3", "Stephen King", "Horror"));
            LibraryCollection.Add(new Book("The Shinning4", "Stephen King", "Horror"));
            LibraryCollection.Add(new Book("The Shinning5", "Stephen King", "Horror"));
        }
    }
}
