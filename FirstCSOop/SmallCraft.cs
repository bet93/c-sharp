using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    // class implements interface IUFO
    internal class SmallCraft : IUFO
    {
        public SmallCraft(string name)
        {
            this.name = name;
            Console.WriteLine("Hi, I am a small craft and my name is " + name);
        }
        public void fly()
        {
            Console.WriteLine("Small craft can't fly around the world.");
        }
        public void goToHyperspace()
        {
            Console.WriteLine("Small craft can't go to hyperspace.");
        }
        public void land()
        {
            Console.WriteLine("Small craft can land.");
        }
    }
}