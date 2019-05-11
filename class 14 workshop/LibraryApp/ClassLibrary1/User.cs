using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }




        public User(string name, string lastname,int id, string email, string pass)
        {
            Name = name;
            lastname = LastName;
            id = Id;
            Email = email;
            Password = pass;
        }
        // creiraj metoda za proverka na pass tuka sto ke vraka bool


    }
}
