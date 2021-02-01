using System;

namespace OOP
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, int age, double weight, double wingspan) : base(name, age, weight)
        {
            WingSpan = wingspan;
        }

        public override void DoSound()
        {
            Console.WriteLine("kvitter, kvitter...");
        }

        public override string Stats()
        {
            return base.Stats() + $", vingbredd: {WingSpan} cm";
        }
    }
}
