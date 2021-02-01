using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Animal
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        #endregion


        public Animal()
        {

        }


        #region Methods
        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }

        #endregion







    }
}
