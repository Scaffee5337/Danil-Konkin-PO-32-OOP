namespace OperatorOverloadingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(150, 80);
            Money m2 = new Money(50, 40);
            Console.WriteLine($"m1: {m1}");
            Console.WriteLine($"m2: {m2}");
            Money sum = m1 + m2;
            Console.WriteLine($"Сложение: {sum}");
            Money difference = m1 - m2;
            Console.WriteLine($"Вычитание: {difference}");
            Money plusInt = m1 + 100;
            Console.WriteLine($"Сложение с int: {plusInt}");
            Console.WriteLine($"m1 > m2: {m1 > m2}");
            Console.WriteLine($"m1 < m2: {m1 < m2}");
            Console.WriteLine($"m1 == m2: {m1 == m2}");
            Console.WriteLine($"m1 != m2: {m1 != m2}");
            if (m1) Console.WriteLine("Счет m1 активен.");
            if (!difference) Console.WriteLine("Баланс отрицательный или нулевой.");
        }
    }
}
