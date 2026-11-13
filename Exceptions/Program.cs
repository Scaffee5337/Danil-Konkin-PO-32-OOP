using System;
namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест 1: корректное деление");
            SafeDivide(10, 2);
            Console.WriteLine();
            SafeDivide(10, 0);
            Console.WriteLine();
            Console.WriteLine("Тест 2.1: (0,0)");
            ProcessTransaction(0,0);
            Console.WriteLine("\n Тест 2.2: (-5, 3)");
            ProcessTransaction(-5, 3);
            Console.WriteLine("\n Тест 2.3: (10, 2)");
            ProcessTransaction(10, 2);
            Console.WriteLine();
            Console.WriteLine("Тест 3.1: невалидная строка 'abc'");
            CalculateSquareTryCatch("abc");
            CalculateSquareTryParse("abc");
            Console.WriteLine("Тест 3.2: валидная строка '15;");
            CalculateSquareTryCatch("15");
            CalculateSquareTryParse("15");
        }
        static void SafeDivide(int x, int y)
        {
            try
            {
                int result = x / y;
                Console.WriteLine($"Результат {x} / {y} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally выполнен всегда.");
            }
        }
        static void ProcessTransaction(int errorCode, int attempts)
        {
            int x = 1, y = 0;
            try
            {
                int res = x / y;
            }
            catch (DivideByZeroException) when (attempts == 0)
            {
                Console.WriteLine("Фильтр 1: Попытки исчерпаны (attempts == 0)");
            }
            catch (DivideByZeroException ex) when (errorCode < 0)
            {
                Console.WriteLine($"Фильтр 2: Отрицательный код {errorCode}: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Общий catch: {ex.Message}");
            }
        }
        static void CalculateSquareTryCatch(string data)
        {
            try
            {
                int val = int.Parse(data);
                Console.WriteLine($"Квадрат: {val * val}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный формат числа");
            }
        }
        // 2. Вариант с TryParse (быстрый и оптимальный):
        static void CalculateSquareTryParse(string data)
        {
            if (int.TryParse(data, out int val))
                Console.WriteLine($"Квадрат: {val * val}");
            else
                Console.WriteLine("Некорректный ввод (без исключения)");
        }
    }
}
