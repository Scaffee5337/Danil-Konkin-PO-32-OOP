using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitAndExplicit
{
    public class MegaByte
    {
        public double Value { get; set; }
        public MegaByte() { }
        public MegaByte(double value)
        {
            Value = value;
        }
        public static implicit operator MegaByte(StorageSize size)
        {
            if (size == null) throw new ArgumentNullException(nameof(size));
            return new MegaByte((long)(size.Bytes / 1048576.0));
        }
    }
}
