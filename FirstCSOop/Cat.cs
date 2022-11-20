using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    // Derived class (child)
    internal class Cat : Animal
    {
        public Cat(string name)
        {
            this.name = name;
            Console.WriteLine("Hi, I am a cat and my name is " + name);
        }
        public void sing()
        {
            Console.WriteLine("Meow! Meow!");
        }
        public void wash()
        {
            Console.WriteLine("I can bathe myself, no need for a bath.");
        }
        public void turnAround()
        {
            Console.WriteLine("I turn around when I no longer need cuddles.");
        }
    }
}