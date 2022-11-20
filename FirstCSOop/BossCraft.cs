using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    // class implements interface IUFO
    internal class BossCraft : IUFO
    {
        public BossCraft(string name)
        {
            this.name = name;
            Console.WriteLine("Hi, I am a boss craft and my name is " + name);
        }
        public void fly()
        {
            Console.WriteLine("Boss craft can fly around the world.");
        }
        public void goToHyperspace()
        {
            Console.WriteLine("Boss craft can go to hyperspace.");
        }
        public void land()
        {
            Console.WriteLine("Boss craft can land.");
        }
    }
}