using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethods
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("[Main] Старт программы.\n");
            await PrintMessageAsync("Загрузка конфигурации", 2000);
            Console.WriteLine("[Main] продолжает рабты основного потока.\n");
            Console.WriteLine("[Main] запуск тяжелого выичисения");
            await Task.Run(() => { Thread.Sleep(1500); });
            Console.WriteLine("[Main] Фоновый расчет успешно завершен.");
            Console.WriteLine("\n[Main] Программа завершила работу.");
            Console.ReadKey();
        }
        static async Task PrintMessageAsync(string message, int delayMs)
        {
            Console.WriteLine($"[Async Start] Начало задачи: {message}");
            await Task.Delay(delayMs);
            Console.WriteLine($"[Async End] Завершена задача: {message}");
        }
    }
}
