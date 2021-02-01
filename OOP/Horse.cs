using System;

namespace OOP
{
    public class Horse : Animal
    {
        public string Breed { get; set; }

        public Horse(string name, string breed, int age, double weight) :
            base(name, age, weight)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Gnägg gnägg");
        }

        public override string Stats()
        {
            return base.Stats() + $", hästras: {Breed}";
        }
    }
}
