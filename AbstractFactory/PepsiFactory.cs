using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();

        }
    }
}
