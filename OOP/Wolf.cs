using System;

namespace OOP
{
    public class Wolf : Animal
    {
        public double TeethLength { get; set; }

        public Wolf(string name, int age, double weight, double teethLength) : base(name, age, weight)
        {
            TeethLength = teethLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("Yl");
        }

        public override string Stats()
        {
            return base.Stats() + $", längd på huggtänder: {TeethLength} cm";
        }
    }
}
