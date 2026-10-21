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
        int Quantity);
}
