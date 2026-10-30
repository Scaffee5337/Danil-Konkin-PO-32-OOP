using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethods
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //1 задание
            Console.WriteLine("[Main] Старт программы.\n");
            await PrintMessageAsync("Загрузка конфигурации", 2000);
            Console.WriteLine("[Main] продолжает рабты основного потока.\n");
            Console.WriteLine("[Main] запуск тяжелого выичисения");
            await Task.Run(() => { Thread.Sleep(1500); });
            Console.WriteLine("[Main] Фоновый расчет успешно завершен.");
            Console.WriteLine("\n[Main] Программа завершила работу.\n");
            //2 задание
            Console.WriteLine("=== Старт демонстрации асинхронности ===\n");
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine("Реализация Сценария А (Последовательное выполнение)");
            await DownloadDataAsync("Сервер 1", 2000);
            await DownloadDataAsync("Сервер 2", 2000);
            await DownloadDataAsync("Сервер 3", 2000);
            stopwatch.Stop();
            long sequentialTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Сценарий А завершён. Общее время: {sequentialTime} мс.\n");
            Console.WriteLine("Реализация Сценария Б (Параллельный запуск)");
            stopwatch.Restart();
            Task task1 = DownloadDataAsync("Сервер 1", 2000);
            Task task2 = DownloadDataAsync("Сервер 2", 2000);
            Task task3 = DownloadDataAsync("Сервер 3", 2000);
            await Task.WhenAll(task1, task2 , task3 );
            stopwatch.Stop();
            long parallelTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Сценарий Б завершён. Общее время: {parallelTime} мс.\n");
            Console.WriteLine($"Последовательно: {sequentialTime} мс.");
            Console.WriteLine($"Параллельно: {parallelTime} мс.");
            Console.WriteLine($"Выигрыш во времени: {sequentialTime - parallelTime} мс.\n");


        }
        static async Task PrintMessageAsync(string message, int delayMs)
        {
            Console.WriteLine($"[Async Start] Начало задачи: {message}");
            await Task.Delay(delayMs);
            Console.WriteLine($"[Async End] Завершена задача: {message}");
        }
        static async Task DownloadDataAsync(string sourceName, int delayMs)
        {
            Console.WriteLine($"[{sourceName}] Загрузка началась");
            await Task.Delay(delayMs);
            Console.WriteLine($"[{sourceName}] Данные успешно загружены");
        }
    }
}
