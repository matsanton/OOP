namespace OOP
{
    public class PersonHandler
    {
        #region Constructor
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(fname, lname)
            {
                Age = age,
                Height = height,
                Weight = weight
            };
            return person;
        }
        #endregion

        #region Setters
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFirstName(Person pers, string fname)
        {
            pers.FName = fname;
        }

        public void SetLastName(Person pers, string lname)
        {
            pers.LName = lname;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        #endregion

        #region Getters
        public int GetAge(Person pers)
        {
            return pers.Age;
        }
        public string GetFullName(Person pers)
        {
            return $"{pers.FName} {pers.LName}";
        }
        public string GetFirstName(Person pers)
        {
            return pers.FName;
        }
        public string GetLastName(Person pers)
        {
            return pers.LName;
        }
        public double GetHeight(Person pers)
        {
            return pers.Height;
        }
        public double GetWeight(Person pers)
        {
            return pers.Weight;
        }
        #endregion


    }
}
