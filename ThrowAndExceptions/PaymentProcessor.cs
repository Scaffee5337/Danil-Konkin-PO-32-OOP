using System;
using System.Collections.Generic;
using System.Text;

namespace ThrowAndExceptions
{
    public class PaymentProcessor
    {
        public static void ProcessTransaction()
        {
            throw new InvalidOperationException("Сбой соединения с сервером");
        }
        public static void ExecutePayment()
        {
            try
            {
                ProcessTransaction();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Лог сервиса]: Логгируем ошибку {ex.Message}");
                throw; // ВАЖНО: повторный проброс без перезаписи StackTrace!
            }
        }
    }
}
