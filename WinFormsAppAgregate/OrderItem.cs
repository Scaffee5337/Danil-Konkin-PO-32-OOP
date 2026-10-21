using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppAgregate
{
    public record OrderItem(
        int Id,
        string CustomerName,
        string ProductName,
        string Category,
        decimal Price,
        int Quantity)
    {
        public virtual bool Equals(OrderItem? other)
        {
            return other is not null && ProductName == other.ProductName;
        }
        public override int GetHashCode()
        {
            return ProductName?.GetHashCode() ?? 0;
        }
    }
}
