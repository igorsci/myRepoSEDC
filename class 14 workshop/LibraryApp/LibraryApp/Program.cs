using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Newtonsoft;
using Newtonsoft.Json;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // creating books list
            
            List<Book> books = new List<Book>()
            {
                new Book("book1",2018,"roman","Igor mitevski",65,4,0,11223),
                new Book("book2", 2016, "com", "stojan stojanov", 33, 10, 0, 1133),
                new Book("book2", 2016, "com", "stojan stojanov", 33, 10, 0, 1133),
                new Book("book2", 2016, "com", "stojan stojanov", 33, 10, 0, 1133),
                new Book("book2", 2016, "com", "stojan stojanov", 33, 10, 0, 1133),
                new Book("book2", 2016, "com", "stojan stojanov", 33, 10, 0, 1133),
                new Book("book2", 2016, "com", "stojan stojanov", 33, 10, 0, 1133),
            };

            // writing books to json
            
            string path1 = @"C:\Users\igor.mitevski\Desktop\IGOR M\c # ADV\class 14 workshop\books.json";

            
            SaveLoadHelper.SaveToFile(books, path1);

            // reading from json bopks

            var rededBooks = SaveLoadHelper.LoadFile(books, path1);

          

            Console.ReadLine();

        }
    }
}
