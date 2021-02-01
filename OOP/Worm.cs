using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public override void DoSound()
        {

        }

        public override string Stats()
        {
            string retValue = base.Stats();
            retValue += IsPoisonous ? ", Warning: Poisonous" : "";
            return retValue;
        }
    }
}
