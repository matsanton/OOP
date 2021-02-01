namespace OOP
{
    public abstract class Animal
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        #endregion

        #region Constructor
        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        #endregion

        #region Methods
        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"{Name}, ålder: {Age} år, vikt: {Weight} kg";
        }
        #endregion

    }
}
