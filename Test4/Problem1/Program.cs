using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate a new Student object
            Student student = new Student();

            Console.WriteLine("========== Problem 1 ==========");
            student.Takedata(32, "Edelita", 2, 0, 7);
            student.Showdata();

    
        }
    }
}
