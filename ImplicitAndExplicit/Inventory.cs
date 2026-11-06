using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitAndExplicit
{
    public class Inventory
    {
        private static int globalCount;
        public int Id { get; }
        public int TotalUnits { get; set; }
        public Inventory() => Id = ++globalCount;
        public void operator +=(int units) => TotalUnits += units;
        public void operator +=(Inventory other) => TotalUnits += other.TotalUnits;
    }
}
