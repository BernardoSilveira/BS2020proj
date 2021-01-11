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
            Users.Add(new Client("Client", "Cliento", "Brambova 45", date1));
            Users.Add(new Staff("Staff", "Staffo", "Brambova 45", date1, Positions.Manager));
            Users.Add(new Client("John", "Adams", "Nasdrova 32", date1));
            Users.Add(new Client("David", "Destro", "Olova 65", date1));
            Users.Add(new Staff("Maria", "Staffova", "Brambova 45", date1, Positions.ClientService));
        }
    }
}
