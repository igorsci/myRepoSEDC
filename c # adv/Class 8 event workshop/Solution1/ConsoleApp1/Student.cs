using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }
        
        public void Verify(Exam e)
        {
            if (e.Points > 50)
            {
                Console.WriteLine(e.Student.FirstName + "" + e.Student.StudentId +"has passed the exam");
            } else
            {
                Console.WriteLine("this student failed");
            }
        }

        public Student(string firstname, string lastname, int id)
        {
            FirstName = firstname;
            LastName = lastname;
            StudentId = id;
        }

    }
}
