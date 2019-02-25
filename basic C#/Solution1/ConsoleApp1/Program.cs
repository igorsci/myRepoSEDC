using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("STOP");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Thread.Sleep(2000);
            Console.WriteLine("prepare");
            Console.Clear();
            Thread.Sleep(3000);
            Console.WriteLine("GO");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Thread.Sleep(5000);

            //Console.ReadKey();
        }
    }
}
