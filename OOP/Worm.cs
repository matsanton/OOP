using System;

namespace OOP
{
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, int age, double weight, bool isPoisonous) : base(name, age, weight)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("<tystnad>");
        }

        public override string Stats()
        {
            return base.Stats() + (IsPoisonous ? ", gifig" : ", ej giftig");
        }
    }
}
