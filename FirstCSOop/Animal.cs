using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSOop
{
    // Base class (parent)
    class Animal
    {
        public void move()
        {
            Console.WriteLine("This Animal is moving");
        }

        public void sleep()
        {
            Console.WriteLine("This Animal is sleeping");
        }

        public void eat()
        {
            Console.WriteLine("This Animal is eating");
        }

    }
}