using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SupplierCatalogAnalitics
{
    public class CatalogService
    {
        private readonly List<Product> supplierA;
        private readonly List<Product> supplierB;
        public CatalogService()
        {
            supplierA = new List<Product>
            {
                new Product(1, "Lenovo Legion", "Ноутбуки", 350000m, "Поставщик A"),
                new Product(2, "Logitech G102", "Мыши", 12000m, "Поставщик A"),
                new Product(3, "Samsung SSD", "Накопители", 25000m, "Поставщик A"),
                new Product(4, "HyperX Cloud", "Наушники", 30000m, "Поставщик A")
            };

            supplierB = new List<Product>
            {
                new Product(5, "LENOVO LEGION", "ноутбуки", 340000m, "Поставщик B"),
                new Product(6, "Logitech G102", "Мыши", 13500m, "Поставщик B"),
                new Product(7, "Kingston SSD", "Накопители", 22000m, "Поставщик B"),
                new Product(8, "A4Tech Bloody", "Мыши", 9000m, "Поставщик B")
            };
        }
        public List<Product> GetExclusiveProductsA()
        {
            return supplierA.Except(supplierB).ToList();
        }
        public List<Product> GetCommonProducts()
        {
            return supplierA.Intersect(supplierB).ToList();
        }
        public List<Product> GetConsolidatedCatalog()
        {
            return supplierA.Union(supplierB).OrderBy(product => product.Category).ThenByDescending(product => product.Price).ToList();
        }
        public List<Product> GetFullRegistry()
        {
            return supplierA.Concat(supplierB).Distinct().ToList();
        }
        public List<Product> GetSupplierA()
        {
            return supplierA.ToList();
        }

        public List<Product> GetSupplierB()
        {
            return supplierB.ToList();
        }
    }
}
