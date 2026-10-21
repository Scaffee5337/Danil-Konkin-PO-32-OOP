using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppAgregate
{
    public class OrderItemComparer : IEqualityComparer<OrderItem>
    {
        public bool Equals(OrderItem? x, OrderItem? y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x is null || y is null) return false;
            return string.Equals(x.ProductName, y.ProductName, StringComparison.OrdinalIgnoreCase);
        }
        public int GetHashCode(OrderItem? obj) 
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.ProductName ?? string.Empty);
        }
    }
}
