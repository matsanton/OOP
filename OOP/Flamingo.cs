namespace OOP
{
    public class Flamingo : Bird
    {
        public double LegLength { get; set; }

        public Flamingo(string name, int age, double weight, double wingspan, double legLength) : base(name, age, weight, wingspan)
        {
            LegLength = legLength;
        }
    }
}
