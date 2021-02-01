namespace OOP
{
    public class Swan : Bird
    {
        public double NeckLength { get; set; }

        public Swan(string name, int age, double weight, double wingspan, double neckLength) : base(name, age, weight, wingspan)
        {
            NeckLength = neckLength;
        }

    }
}
