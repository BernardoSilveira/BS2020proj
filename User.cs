using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS2020proj
{
    public enum Positions { Manager, ClientService, Trainee}

    [Serializable()]
    public abstract class User
    {
        protected User(string name, string surname, string address, DateTime birthdate)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
    }

    [Serializable()]
    public class Staff : User
    {
        public Staff(string name, string surname, string address, DateTime birthdate, Positions position) 
            : base(name, surname, address, birthdate)
        {
            Position = position;
        }

        public Positions Position { get; set; }
    }

    [Serializable()]
    public class Client : User
    {
        public Client(string name, string surname, string address, DateTime birthdate)
            : base(name, surname, address, birthdate)
        {
        }

        public BindingList<Book> ReservedBooks { get; private set; } = new BindingList<Book>();
        public BindingList<Book> RentedBooks { get; private set; } = new BindingList<Book>();
    }
}
