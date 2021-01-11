using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS2020proj
{
    [Serializable()]
    public class Book
    {
        public Book(string title, string author, string genre, int published, bool available)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Published = published;
            Available = available;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Published { get; set; } // Year of publication
        public bool Available { get; set; } = true; //not booked or rented
    }
}
