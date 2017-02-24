using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assisgnment1_CP330
{
    class withSteel: ShipDecorator
    {
        private int steelWeight;
        public withSteel(IShip IS) : base(IS)
        {
            steelWeight = 75;
            Ship shipSteel = new Ship();
        }
        public double weight()
        {
            return base.weight() + steelWeight;
        }

        public string ShipDescription()
        {
            return base.ShipDescription() + "with Steel armour";
        }
        public void PrntMe() //created this function just to test with the console if the program was working correctly
        {
            Console.WriteLine(weight());
            Console.WriteLine(ShipDescription());
        }
    }
}
