using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


   

   public class Trainer
    {
        public delegate void ResultsHandler(Exam exam);

        public event ResultsHandler StudentResults;

        public void ResultsAnnouncement(Exam exam)
        {
            if(StudentResults != null)
            {
                StudentResults(exam);
                //Console.WriteLine(exam.Student.FirstName + "with id" + exam.Student.StudentId + "has points" + exam.Points);
            }
            
        }

    }
}
