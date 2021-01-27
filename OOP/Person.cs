using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Person
    {
        #region Private fields
        private int age = 1;
        private string fName;
        private string lName;
        private double height;
        private double weight;
        #endregion

        #region Public properties
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be greater than zero.");
                }
                age = value;

            }
        }
        public string FName 
        {
            get
            {
                return fName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("FName is too short or too long.");
                }
                fName = value;
            }
        }
        public string LName 
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("LName is too short or too long.");
                }
                lName = value;
            }
        }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        #endregion

        #region Constructors
        public Person(string firstName, string lastName)
        {
            FName = firstName;
            LName = lastName;
        }
        #endregion
    }
}
