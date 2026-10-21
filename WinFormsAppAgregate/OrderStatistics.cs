using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WinFormsAppAgregate
{
    public static class OrderStatistics
    {
        public static string GetOnlineStatistics(
            List<OrderItem> onlineOrders)
        {
            int totalOrders = onlineOrders.Count();

            int expensiveOrders = onlineOrders.Count(
                x => x.Price * x.Quantity > 1000);

            decimal totalRevenue = onlineOrders.Sum(
                x => x.Price * x.Quantity);

            decimal averagePrice = onlineOrders.Count > 0
                ? onlineOrders.Average(x => x.Price)
                : 0m;

            decimal minPrice = onlineOrders.Count > 0
                ? onlineOrders.Min(x => x.Price)
                : 0m;

            decimal maxPrice = onlineOrders.Count > 0
                ? onlineOrders.Max(x => x.Price)
                : 0m;

            string categories = onlineOrders
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
                .Aggregate(
                    "Категории: ",
                    (result, category) =>
                        result + category + ", ");
            return $"Всего онлайн-заказов: {totalOrders}\n" + $"Заказов на сумму более 1000 руб.: {expensiveOrders}\n" + $"Общая выручка: {totalRevenue:F2} руб.\n" +
                $"Средняя цена товара: {averagePrice:F2} руб.\n" +
                $"Минимальная цена: {minPrice:F2} руб.\n" +
                $"Максимальная цена: {maxPrice:F2} руб.\n" +
                $"{categories.TrimEnd(',', ' ')}";
        }
            public static string GetProductComparison(
    List<OrderItem> onlineOrders,
    List<OrderItem> storeOrders)
        {
            var comparer = new OrderItemComparer();
            var onlineOnly = onlineOrders
                .Select(x => x.ProductName)
                .Except(
                    storeOrders.Select(x => x.ProductName),
                    StringComparer.OrdinalIgnoreCase);
            var common = onlineOrders
                .Select(x => x.ProductName)
                .Intersect(
                    storeOrders.Select(x => x.ProductName),
                    StringComparer.OrdinalIgnoreCase);
            var allProducts = onlineOrders
                .Select(x => x.ProductName)
                .Union(
                    storeOrders.Select(x => x.ProductName),
                    StringComparer.OrdinalIgnoreCase);
            var concatenated = onlineOrders
                .Select(x => x.ProductName)
                .Concat(storeOrders.Select(x => x.ProductName))
                .Distinct(StringComparer.OrdinalIgnoreCase);
            bool resultsMatch = new HashSet<string>(
                allProducts, StringComparer.OrdinalIgnoreCase)
                .SetEquals(concatenated);
            var onlineOnlyItems = onlineOrders.Except(
                storeOrders, comparer);

            var commonItems = onlineOrders.Intersect(
                storeOrders, comparer);

            return
                $"Только онлайн: {string.Join(", ", onlineOnly)}\n" +
                $"Общие товары: {string.Join(", ", common)}\n" +
                $"Все товары: {string.Join(", ", allProducts)}\n" +
                $"Concat + Distinct совпадает с Union: {resultsMatch}\n" +
                $"Объектов только онлайн: {onlineOnlyItems.Count()}\n" +
                $"Общих объектов по названию: {commonItems.Count()}";
        }
    }
}
