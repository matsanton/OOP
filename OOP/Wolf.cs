using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Wolf : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Aooooo");
        }

        public Wolf(): base()
        {

        }

        public override string Stats()
        {
            return base.Stats(); 
        }
    }
}
