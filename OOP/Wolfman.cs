using System;

namespace OOP
{
    public class Wolfman : Wolf, IPerson
    {
        public int ShoeSize { get; set; }

        public Wolfman(string name, int age, double weight, double teethLength, int shoeSize) :
            base(name, age, weight, teethLength)
        {
            ShoeSize = shoeSize;
        }

        public void Talk()
        {
            Console.WriteLine("Werewolf howles...");
        }

        public override string Stats()
        {
            return base.Stats() + $", Skostorlek {ShoeSize}";
        }

    }
}
