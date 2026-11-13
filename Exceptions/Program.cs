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
    }
}
