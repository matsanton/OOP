using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(): base()
        {

        }

        public override void DoSound()
        {
            Console.WriteLine("Tweet, tweet...");
        }

        public override string Stats()
        {
            return base.Stats() + $", Wing span: {WingSpan}";
        }
    }
}
