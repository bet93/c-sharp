using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Batsman
    {
        private int bcode;
        private string? bname;
        private int innings, notout, runs;
        private float batavg;

        private void calcavg()
        {
            this.batavg = (float)this.runs / (this.innings - this.notout);
        }

        public void readdata()
        {
            Console.WriteLine("Enter batsman code: ");
            this.bcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter batsman name: ");
            this.bname = Console.ReadLine();

            Console.WriteLine("Enter innings: ");
            this.innings = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter notout: ");
            this.notout = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter runs: ");
            this.runs = Convert.ToInt32(Console.ReadLine());

            calcavg();
        }

        public void displaydata()
        {
            Console.WriteLine("You have entered ");
            Console.WriteLine("Batsman codde: {0}\nBatsman name: {1}\nInnings: {2}\nNotout: {3}\nRuns: {4}\nBating avarage: {4}", this.bcode, this.bname, this.innings, this.notout, this.runs, this.batavg);
        }
    }
}