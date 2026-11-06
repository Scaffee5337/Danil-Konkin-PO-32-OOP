using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitAndExplicit
{
    public class StorageSize
    {
        public long Bytes { get; set; }
        public StorageSize(long bytes)
        {
            Bytes = bytes;
        }
        public static implicit operator StorageSize(long bytes)
        {
            return new StorageSize(bytes);
        }
        public static explicit operator long(StorageSize size)
        {
            if (size == null) throw new ArgumentNullException(nameof(size));
            return size.Bytes;
        }
    }
}
