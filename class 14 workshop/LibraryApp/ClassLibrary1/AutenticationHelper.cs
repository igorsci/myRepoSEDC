using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    class AutenticationHelper
    {
        public static bool CheckEmal(List<User>users, string email, string path)
        {
            var checker = false;
            var usersList = SaveLoadHelper.LoadFile(users, path);
            List<string> emails = usersList.Select(x => x.Email).ToList();
            email = email.Trim().ToLower();
            
            foreach (var item in emails)
            {
                if (item == email)
                {
                    checker = true;
                } else
                {
                    checker = false;
                }
            }
            return checker;
            // procitaj od fajlot so useri
            // zemi ja email adresata i napravi nova lsita od stringovi
            // proveri ja listata i vidi dali email e sovpadnat so listata od emailovi


            
        }
    }
}
