using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    // implements interface IUFO
    internal class LargeCraft : IUFO
    {
        public void fly()
        {
            Console.WriteLine("Large craft can fly around the world.");
        }
        public void goToHyperspace()
        {
            Console.WriteLine("Large craft can't go to hyperspace.");
        }
        public void land()
        {
            Console.WriteLine("Large craft can land.");
        }
    }
}