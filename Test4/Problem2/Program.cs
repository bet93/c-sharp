using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate a new Batsman object
            Batsman batsman = new Batsman();
            batsman.readdata();
            batsman.displaydata();
        }
    }
}

