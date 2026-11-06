using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundAssignment
{
    public class Inventory
    {
        private static int globalCount;
        public int Id { get; }
        public int TotalUnits { get; set; }
        public Inventory() => Id = ++globalCount;
        public virtual void operator +=(int units) => TotalUnits += units;
        public void operator ++() => TotalUnits++;
        public static Inventory operator ++(Inventory inv)
        {
            return new Inventory
            {
                TotalUnits = inv.TotalUnits + 1
            };
        }
    }
}
