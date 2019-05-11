using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Book
    {
        public string Title { get; set; }
        public int PubYear { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfCopies { get; set; }
        public int NumberOfRents { get; set; }
        public int ISBN { get; set; }

        public Book (string title, int pubYear, string genre, string author, int numOfPages, int numOfCopies, int numOfRents, int isbn)
        {
            Title = title;
            PubYear = pubYear;
            Genre = genre;
            Author = author;
            NumberOfPages = numOfPages;
            NumberOfCopies = numOfCopies;
            NumberOfRents = numOfRents;
            ISBN = isbn;
        }
        
    }
}
