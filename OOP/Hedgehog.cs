using System;

namespace OOP
{
    public class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public Hedgehog(string name, int numberOfSpikes, int age, double weight) : base(name, age, weight)
        {
            NumberOfSpikes = numberOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("mjau");
        }

        public override string Stats()
        {
            return base.Stats() + $", antal taggar: {NumberOfSpikes}";
        }

    }
}
