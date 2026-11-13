namespace ThrowAndExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Явная генерация исключения и валидация");
            try
            {
                UserRegistration.RegisterUser("A", 15);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"[Ошибка аргумента]: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"[Некорректное имя]: {ex.Message}");
            }
            Console.WriteLine("\n Задание 2. Повторный проброс исключений");
            try
            {
                PaymentProcessor.ExecutePayment();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n Трассировка стека (StackTrace) в Main");
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("\n Задание 3. Каскад блоков catch и иерархия типов");
            try
            {
                DataParser.ParseAndDivide(new string[] { "100", "abc" }, 1, 0);
            }
            catch (DivideByZeroException ex) { Console.WriteLine("Деление на ноль!"); }
            catch (FormatException ex) { Console.WriteLine("Неверный формат числа!"); }
            catch (IndexOutOfRangeException ex) { Console.WriteLine("Индекс вне диапазона!"); }
            catch (Exception ex) { Console.WriteLine($"Общая ошибка: {ex.Message}"); }
        }
    }
}
