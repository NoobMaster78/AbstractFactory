using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }
    }
}
