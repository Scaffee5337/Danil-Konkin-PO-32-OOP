using System;
using System.Collections.Generic;
using System.Text;
namespace SupplierCatalogAnalytics
{
    public class Product : IEquatable<Product>
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }
        public decimal Price { get; private set; }
        public string Supplier { get; private set; }

        public Product(int id, string name, string category, decimal price, string supplier)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Supplier = supplier;
        }

        public bool Equals(Product other)
        {
            if (ReferenceEquals(other, null))
                return false;

            return string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase) && string.Equals(Category, other.Category, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Product);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StringComparer.OrdinalIgnoreCase.GetHashCode(Name ?? string.Empty), StringComparer.OrdinalIgnoreCase.GetHashCode(Category ?? string.Empty)
            );
        }
    }
}
