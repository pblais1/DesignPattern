using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assisgnment1_CP330
{
    class withHoneycomb: ShipDecorator
    {
        private double honeycombWeight;
        public withHoneycomb(IShip IS) : base(IS)
        {
            honeycombWeight = 0.8;
            Ship shipHoneycomb = new Ship();
        }
        public double weight()
        {
            double baseWeight = (double)base.weight();
            return baseWeight * honeycombWeight;
        }

        public string ShipDescription()
        {
            return base.ShipDescription() + "with honey comb armour";
        }
        public void PrntMe() //created this function just to test with the console if the program was working correctly
        {
            Console.WriteLine(weight());
            Console.WriteLine(ShipDescription());
        }
    }
}
