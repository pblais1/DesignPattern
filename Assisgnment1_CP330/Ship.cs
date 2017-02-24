using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assisgnment1_CP330
{
    class Ship: IShip
    {
        public string ShipDescription()
        {
            return "Ship ";
        }
        public double weight()
        {
             return 10;
        }
    }
}
