using System;
using System.Collections.Generic;
using System.Linq;

namespace DeferredAndImmediateLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] candidates = { "Анна", "Борис", "Олег", "Ирина"};
            Console.WriteLine("Deferred execution:");
            var deferredQuery = candidates.Where(name => name.Length == 4).OrderBy(name => name);
            candidates[2] = "Игорь";
            Console.WriteLine("Результат отложенного запроса:");
            foreach (var name in deferredQuery)
            {
                Console.WriteLine(name);
            }
        }
    }
}
