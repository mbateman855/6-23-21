using System;
using System.Collections.Generic;
using System.Text;

namespace _6_23_21
{
    class Cat : Animal
    {
        public int NumberOfClaws { get; set; }

        public Cat()
        {
        }
        public void Meow()
        {
            Console.WriteLine("MEOW");
        }
    }
}
