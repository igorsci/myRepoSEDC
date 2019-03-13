using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.classes;

namespace ConsoleApp1
{
    class Program
    {

        //static void NUmberStat(double number)
        //{
        //    if (number < 0)
        //    {
        //        Console.WriteLine("negative");
        //    } else
        //    {
        //        Console.WriteLine("positive");
        //    }

        //    if (number % 2 == 0)
        //    {
        //        Console.WriteLine("Odd");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Even");
        //    }

        //    if (number % 1 == 0)
        //    {
        //        Console.WriteLine("Integer");
        //    }
        //    else
        //    {
        //        Console.WriteLine("decimal");
        //    }



        //}
        static void Main(string[] args)

        {

            //double truenum;

            //while(true)
            //{
            //    Console.WriteLine("please enter your number");
            //    string mynumber = Console.ReadLine();
            //    bool num1 = Double.TryParse(mynumber, out truenum);

            //    if(num1)
            //    {
            //        break;
            //    }

            //}

            //while (true)
            //{
            //    Console.WriteLine("continue Y exit X");
            //    string cont = Console.ReadLine();
            //    if (cont == "Y")
            //    {
            //        NUmberStat(truenum);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}


            User[] array = new User[3] ;

            array[0] = new User()
            {
                Id = 1111,
                Username = "igor_i",
                Password = "igorce",
                Messages = new string[3] { "user one messe1", "oser one messes 2", "user one messe 3" }


            };

            array[1] = new User()
            {
                Id = 1122,
                Username = "antita_jo",
                Password = "anitajov",
                Messages = new string[3] { "user two messe1", "oser two messes 2", "user two messe 3" }


            };

            array[2] = new User()
            {
                Id = 1133,
                Username = "jovan_jovan",
                Password = "jovance",
                Messages = new string[3] { "user three messe1", "oser three messes 2", "user three messe 3" }


            };

            Console.WriteLine("please login");
            Console.WriteLine("please enter your user name");

            string myusername = Console.ReadLine();

            Console.WriteLine("please enter password");


            string pass = Console.ReadLine();

            bool isUserFound = false;
            User foundUser=null;

            foreach (var item in array)
            {
                if(item.Username== myusername && item.Password==pass)
                {
                    isUserFound = true;
                    foundUser = item;
                }
                //else
                //{
                //    Console.WriteLine("wrong username or password");

                //}
                
            }

            if (isUserFound)
            {
                Console.WriteLine($"welcome{myusername} here are your messages");

                foreach (var mes in foundUser.Messages)
                {

                    Console.WriteLine(mes);
                }
            } else
            {
                Console.WriteLine("the user is not found please register");
            }

            Console.WriteLine("enter your id");
            int addId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your username");
            string addUser = Console.ReadLine();

            Console.WriteLine("enter your password");
            string addPass = Console.ReadLine();

            Array.Resize(ref array, 10);
            array[4] = new User()
            {
                Id = addId,
                Username = addUser,
                Password = addPass

            };


            //if (isUserFound)
            //{
            //    Console.WriteLine("user is found here are his messages");
            //    //Console.WriteLine(item.Messages);
            //    foreach (var mesage in )
            //    {

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("eror");
            //}







            Console.ReadLine();
        }
    }
}
