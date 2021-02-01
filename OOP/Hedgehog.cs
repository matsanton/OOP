using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public override void DoSound()
        {
            throw new NotImplementedException();
        }

        public override string Stats()
        {
            return base.Stats() + $", Spikes: {NumberOfSpikes}";
        }


    }
}
