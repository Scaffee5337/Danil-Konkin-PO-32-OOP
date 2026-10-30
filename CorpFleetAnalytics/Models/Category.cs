using System;
using System.Collections.Generic;
using System.Text;

namespace CorpFleetAnalytics.Models
{
    public class Category
    {
        public int Id { get; private set; }
        public string CategoryName { get; private set; }
        public double TaxRate { get; private set; }
        public Category(int id, string categoryName, double taxRate)
        {
            if (id < 0) throw new ArgumentException("ID не может быть отрицательным.");
            if (string.IsNullOrWhiteSpace(categoryName)) throw new ArgumentException("Название категории не может быть пустым.");
            if (taxRate < 0) throw new ArgumentException("Налоговая ставка не может быть отрицательной.");
            Id = id;
            CategoryName = categoryName;
            TaxRate = taxRate;
        }
        public override string ToString()
        {
            return $"{CategoryName} (налог: {TaxRate}%)";
        }
    }
}
