using System;

namespace OOP
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string breed, int age, double weight) : base(name, age, weight)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Voff, voff");
        }

        public override string Stats()
        {
            return base.Stats() + $", ras: {Breed}";
        }

        public string Info()
        {
            return "Endast för hundar.";
        }
    }
}
