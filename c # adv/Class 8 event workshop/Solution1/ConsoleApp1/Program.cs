using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer train1 = new Trainer();


            Student st1 = new Student("igor", "mitevski", 1);
            Student st2 = new Student("anita", "jovanovska", 2);
            List<Student> students = new List<Student>();
            students.Add(st1);
            students.Add(st2);


            List<Exam> examResults = new List<Exam>();
            examResults.Add(new Exam() { Student = st1, Points = 45 });
            examResults.Add(new Exam() { Student = st2, Points = 60 });

            train1.StudentResults += st1.Verify;


            foreach (var item in examResults)
            {
                train1.ResultsAnnouncement(item);
            }
            
           
            Console.ReadLine();
        }

        

    }


}
