using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace BS2020proj
{
    public static class Database
    {
        public static BindingList<User> Users { get; private set; } = new BindingList<User>();
        public static BindingList<Book> LibraryCollection { get; private set; } = new BindingList<Book>();

        static Database()
        {
            /*DateTime date1 = new DateTime(1982, 08, 12);
            User u1 = new Client("Client", "Cliento", "Brambova 45", date1, true);
            Users.Add(u1);
            Users.Add(new Staff("Staff", "Staffo", "Brambova 45", date1, Positions.Manager));
            User u2 = new Client("John", "Adams", "Nasdrova 32", date1, true);
            Users.Add(u2);
            Users.Add(new Client("David", "Destro", "Olova 65", date1));
            Users.Add(new Staff("Maria", "Staffova", "Brambova 45", date1, Positions.ClientService));
            Users.Add(new Client("Marc", "David", "Bluova 90", date1));
            u1.ReservedBooks.Add(new Book("Book6", "Author6", "Genre4"));
            u1.RentedBooks.Add(new Book("Book7", "Author7", "Genre5"));
            u2.ReservedBooks.Add(new Book("Book8", "Author8", "Genre6"));

            LibraryCollection.Add(new Book("Book", "Author", "Genre"));
            LibraryCollection.Add(new Book("Book1", "Author1", "Genre1"));
            LibraryCollection.Add(new Book("Book2", "Author2", "Genre2"));
            LibraryCollection.Add(new Book("Book3", "Author3", "Genre2"));
            LibraryCollection.Add(new Book("Book4", "Author4", "Genre3"));
            LibraryCollection.Add(new Book("Book5", "Author5", "Genre1"));*/

            Deserialize();
        }

        public static BindingList<User> FindClientInWait(BindingList<User> list)
        {
            BindingList<User> result =  new BindingList<User>();
            for (int i = 0; i < list.Count; i++) 
            { 
                if(list[i] is Client && (list[i] as Client).PickupReady)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        public static List<int> FindClientInWaitIndex(BindingList<User> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Client && (list[i] as Client).PickupReady)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static void Reserve(object oClient, object oBook)
        {
            Client client = (Client)oClient;
            Book book = (Book)oBook;

            client.ReservedBooks.Add(book);
            LibraryCollection.Remove(book);
        }

        public static void Rent(object oClient, object oBook)
        {
            Client client = (Client)oClient;
            Book book = (Book)oBook;

            client.RentedBooks.Add(book);
            client.ReservedBooks.Remove(book);
        }

        public static void Return(object oClient, object oBook)
        {
            Client client = (Client)oClient;
            Book book = (Book)oBook;

            LibraryCollection.Add(book);
            client.RentedBooks.Remove(book);
        }

        public static void Serialize()
        {
            Serialize(Users, "users.bin");
            Serialize(LibraryCollection, "librarycollection.bin");
        }

        public static void Serialize<T>(BindingList<T> list, string file)
        {
            using (Stream s = File.Open(file, FileMode.Create))
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, list);
            }
        }

        public static void Deserialize()
        {
            Users = Deserialize<User>("users.bin");
            LibraryCollection = Deserialize<Book>("librarycollection.bin");
        }

        public static BindingList<T> Deserialize<T>(string file)
        {
            using (Stream s = File.Open(file, FileMode.Open))
            {
                BinaryFormatter b = new BinaryFormatter();
                return (BindingList<T>)b.Deserialize(s);
            }
        }
    }
}
