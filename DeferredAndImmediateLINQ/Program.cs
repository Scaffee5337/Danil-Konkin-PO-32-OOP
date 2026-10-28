using System;
using System.Collections.Generic;
using System.Linq;

namespace DeferredAndImmediateLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] candidates = { "Анна", "Борис", "Олег", "Ирина" };
            Console.WriteLine("---Deferred execution (Отложенное). Task 1----:");
            var deferredQuery = candidates.Where(name => name.Length == 4).OrderBy(name => name);
            candidates[2] = "Игорь";
            Console.WriteLine("Результат отложенного запроса:");
            foreach (var name in deferredQuery)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n---Немедленное выполнение (Immediate). Задание 2");
            candidates[2] = "Олег";
            List<string> immediateList = candidates.Where(name => name.Length == 4)
                .OrderBy(name => name).ToList();
            candidates[0] = "Алена";
            Console.WriteLine("Результат из закэшированного списка ToList():");
            foreach (var name in immediateList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
