using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assisgnment1_CP330
{
    abstract class ShipDecorator: IShip
    {
        private IShip armouredShip;

       public ShipDecorator(IShip IS)
        {
            this.armouredShip = IS;
        }

        public double weight()
        {
           return armouredShip.weight();
        }
        public string ShipDescription()
        {
           return armouredShip.ShipDescription();
        }
    }
}
