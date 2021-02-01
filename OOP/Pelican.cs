namespace OOP
{
    public class Pelican : Bird
    {
        public double BeekVolume { get; set; }

        public Pelican(string name, int age, double weight, double wingspan, double beekVolume) : base(name, age, weight, wingspan)
        {
            BeekVolume = beekVolume;
        }

    }
}

