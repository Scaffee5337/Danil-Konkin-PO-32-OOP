namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double res1 = MathOperations.SafeDivide(10, 2); // Успех -> выведется result и finally
                double res2 = MathOperations.SafeDivide(5, 0); // Исключение -> перехват в catch и finally
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Внешний перехват: {ex.Message}");
            }
        }
    }
}
