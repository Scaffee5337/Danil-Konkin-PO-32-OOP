using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatchFinally
{
    public class AccountProcessor
    {
        public void ProcessTransaction(int status, int amount)
        {
            try
            {
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Сумма транзакции не может быть отрицательной.");
                }
                Console.WriteLine($"Транзакция со статусом {status} на сумму {amount} успешно проведена.");
            }
            catch (ArgumentOutOfRangeException ex) when (amount < -1000)
            {
                Console.WriteLine($"Критически недопустимая сумма! ({ex.Message})");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка диапазона аргументов: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Непредвиденная ошибка при обработке транзакции: {ex.Message}");
            }
        }
    }
}
