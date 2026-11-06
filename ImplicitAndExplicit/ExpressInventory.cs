using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundAssignment
{
    public class ExpressInventory : Inventory
    {
        public override void operator +=(int units) => TotalUnits += units * 2;
    }
}
