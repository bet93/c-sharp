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
        private char[] sname = new char[20];
        private float eng, math, science, total;

        // a function that calculates eng + math + science and returns a float value
        private float ctotal()
        {
            return this.eng + this.math + this.science;
        }

        // a function that accepts values for admno, sname, eng, science and invokes
        // ctotal() to calculate total.
        public void Takedata(int admno, string sname, float eng, float math, float science)
        {
            this.admno = admno;
            this.sname = sname.ToCharArray();
            this.eng = eng;
            this.math = math;
            this.science = science;

            this.total = ctotal();
        }

        // a function that displays all the data members on the screen.
        public void Showdata()
        {
            Console.WriteLine("Student admno:   " + this.admno);
            Console.WriteLine("Student name:    " + new string(this.sname));
            Console.WriteLine("Student eng:     " + this.eng);
            Console.WriteLine("Student math:    " + this.math);
            Console.WriteLine("Student science: " + this.science);
            Console.WriteLine("Student total:   " + this.total);
        }
    }
}