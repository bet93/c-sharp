using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    // Derived class (child)
    internal class Dog : Animal
    {
        public Dog(string name)
        {
            this.name = name;
            Console.WriteLine("Hi, I am a dog and my name is " + name);
        }
        public void sing()
        {
            Console.WriteLine("Woof! Woof!");
        }
        public void wash()
        {
            Console.WriteLine("I do not enjoy baths very much like other dogs do, im don't like the water!");
        }
        public void turnAround()
        {
            Console.WriteLine("I like turning around in circles because I always get treats when I do!");
        }
    }
}