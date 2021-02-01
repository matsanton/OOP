using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Horse : Animal
    {

        public string Breed { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Yeeeee");
        }


        public override string Stats()
        {
            return base.Stats() + $"Breed: {Breed}";
        }
    }
}
