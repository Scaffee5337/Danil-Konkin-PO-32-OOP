using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatchFinally
{
    public class MathOperations
    {
        public static double SafeDivide(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Деление на ноль невозможно");
                }
                return b / a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка в SafeDivide: {ex.Message}");
                return double.NaN;
            }
            finally
            {
                Console.WriteLine("Операция деления завершена");
            }
        }
    }
}
