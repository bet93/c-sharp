using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Student
    {
        private int admno;
        private string? sname;
        private float eng, math, science, total;

        // a function that calculates eng + math + science and returns a float value
        private float ctotal()
        {
            return this.eng + this.math + this.science;
        }

        // a function that accepts values for admno, sname, eng, science and invokes
        // ctotal() to calculate total.
        public void Takedata()
        {
            Console.WriteLine("Enter admission number: ");
            this.admno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter student name: ");
            this.sname = Console.ReadLine();

            Console.WriteLine("Enter english grade: ");
            this.eng = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter math grade: ");
            this.math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter science grade: ");
            this.science = Convert.ToInt32(Console.ReadLine());

            this.total = ctotal();
        }

        // a function that displays all the data members on the screen.
        public void Showdata()
        {
            Console.WriteLine("Student admno:   " + this.admno);
            Console.WriteLine("Student name:    " + this.sname);
            Console.WriteLine("Student eng:     " + this.eng);
            Console.WriteLine("Student math:    " + this.math);
            Console.WriteLine("Student science: " + this.science);
            Console.WriteLine("Student total:   " + this.total);
        }
    }
}