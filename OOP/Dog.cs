using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Dog : Animal
    {
        public string Breed { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Voff, voff");
        }

        public override string Stats()
        {
            return base.Stats() + $"Breed: {Breed}";
        }
    }
}
