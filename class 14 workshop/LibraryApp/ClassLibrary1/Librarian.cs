using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Librarian :User    
    {
        // ima pristap do knigite, moze da dodva i da odzema knigi
        public List<Book> Books { get; set; }

        public Librarian(string name, string lastname, int id, string email, string pass, List<Book> books) : base(name, lastname, id, email, pass)
        {
            books = new List<Book>();
        }
    }
}
