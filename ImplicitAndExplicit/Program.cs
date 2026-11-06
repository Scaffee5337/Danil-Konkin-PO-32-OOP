using CompoundAssignment;

namespace ImplicitAndExplicit
{
    class Program
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

            Console.WriteLine();
            var warehouse = new Inventory { TotalUnits = 100 };
            Console.WriteLine(warehouse.Id); // Id: 1
            warehouse += 50;
            warehouse += 25;
            Console.WriteLine(warehouse.Id); // Id по-прежнему 1! Новый объект не создавался.

            Console.WriteLine();
            Console.WriteLine($"Общий склад: {warehouse.TotalUnits}");
            ++warehouse;
            Console.WriteLine($"После ++: {warehouse.TotalUnits}" );
            Inventory next = warehouse++;
            Console.WriteLine($"Предыдущий: {next.Id}, {next.TotalUnits}");
            Console.WriteLine($"Последующий: {warehouse.Id}, {warehouse.TotalUnits}");
            var expressWarehouse = new ExpressInventory { TotalUnits = 100 };
            expressWarehouse += 10;
            Console.WriteLine($"Срочный после += 10: {expressWarehouse.TotalUnits}" );
        } 
    }
}
