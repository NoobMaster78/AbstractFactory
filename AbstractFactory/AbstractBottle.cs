using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
    }
}
