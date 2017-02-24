using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assisgnment1_CP330
{
    class withNano : ShipDecorator
    {
       private int nanoWeight;
        public withNano(IShip IS) : base(IS)
        {
            nanoWeight = 1;
            Ship shipNano = new Ship();
        }
        public double weight()
        {
           return base.weight() + nanoWeight;
        }
        public string ShipDescription()
        {
            return base.ShipDescription() + "with nano armour";
        }
        public void PrntMe() //created this function just to test with the console if the program was working correctly
        {
            Console.WriteLine(weight());
            Console.WriteLine(ShipDescription());
        }

    }
}
