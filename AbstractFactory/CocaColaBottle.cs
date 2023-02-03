using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + "interacts with " + water);
        }
    }
}
