using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    // Derived class (child)
    internal class Bird : Animal
    {
        private string name = "Tweety";

        public Bird(string name)
        {
            this.name = name;
            Console.WriteLine("Hi, I am a bird and my name is " + name);
        }
        public void sing()
        {
            Console.WriteLine("Chirp! Chirp!");
        }
        public void wash()
        {
            Console.WriteLine("It's time for my daily bath!");
        }
        public void turnAround()
        {
            Console.WriteLine("I turn around in circles in flight to reduce the amount of energy I use.");
        }
    }
}