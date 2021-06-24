using System;
using System.Collections.Generic;
using System.Text;

namespace _6_23_21
{
    public class Animal
    {
        public int MNumberOfLimbs { get; set; }
        public string Color { get; set; }
        public int NumberOfEyes { get; set; }
        public bool HasTail { get; set; }
        public int Weight { get; set; }
        public Animal()
        {

        }
        public void Eat()
        {
            Console.WriteLine("I am eating!");
        }
    }
}
