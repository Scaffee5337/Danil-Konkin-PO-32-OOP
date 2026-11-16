namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Базовая обработка и гарантия зачистки ресурсов");
            try
            {
                double res1 = MathOperations.SafeDivide(10, 2); // Успех -> выведется result и finally
                double res2 = MathOperations.SafeDivide(5, 0); // Исключение -> перехват в catch и finally
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Внешний перехват: {ex.Message}");
            }
            Console.WriteLine("\n Задание 2. Иерархия исключений и каскадная фильтрация catch when");
            AccountProcessor processor = new AccountProcessor();
            processor.ProcessTransaction(1, 500);
            processor.ProcessTransaction(1, -50);
            processor.ProcessTransaction(1, -2000);
            int x = 0; int y = 1;
            try
            {
                int result1 = x / y;
                int result2 = y / x; // Ошибка: деление на ноль (x == 0)
            }
            catch (DivideByZeroException) when (y == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Обработано во втором catch: {ex.Message}");
            }
        }
    }
}
