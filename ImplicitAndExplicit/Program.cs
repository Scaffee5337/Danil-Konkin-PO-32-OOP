using System;

namespace ImplicitAndExplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StorageSize size1 = 2097152L;
            Console.WriteLine("Исходный объем данных:");
            Console.WriteLine($"{size1.Bytes} байт");
            long explicitBytes = (long)size1;

            Console.WriteLine("\nЯвное преобразование в long:");
            Console.WriteLine($"{explicitBytes} байт");
            MegaByte mb = size1;

            Console.WriteLine("\nНеявное преобразование в MegaByte:");
            Console.WriteLine($"{mb.Value} МБ");

            StorageSize size2 = (StorageSize)new MegaByte
            {
                Value = 1.5
            };

            Console.WriteLine("\nЯвное преобразование MegaByte -> StorageSize:");
            Console.WriteLine($"{size2.Bytes} байт");

            StorageSize testSize = 1572864L;
            MegaByte testMb = testSize;

            Console.WriteLine($"\nПроверка дробного значения:");
            Console.WriteLine($"{testSize.Bytes} байт = {testMb.Value} МБ");
        }
    }
}
