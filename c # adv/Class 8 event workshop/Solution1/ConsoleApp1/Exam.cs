using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exam : EventArgs
    {
        public Student Student { get; set; }
        public int Points { get; set; }
    }
}
