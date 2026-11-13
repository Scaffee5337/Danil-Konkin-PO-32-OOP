using System;
using System.Collections.Generic;
using System.Text;

namespace ThrowAndExceptions
{
    public class DataParser
    {
        public static void ParseAndDivide(string[] data, int index, int divisor)
        {
            if (data == null)
            {
                throw new NullReferenceException("Массив данных не инициализирован (null)");
            }
            string rawValue = data[index];
            int number = int.Parse(rawValue);
            int result = number / divisor;
            Console.WriteLine($"Результат: {result}");
        }
    }
}
