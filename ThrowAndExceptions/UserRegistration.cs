using System;
using System.Collections.Generic;
using System.Text;

namespace ThrowAndExceptions
{
    public class UserRegistration
    {
        public static void RegisterUser(string username, int age)
        {
            if (username == null || username.Length < 2)
            {
                throw new ArgumentNullException("Имя пользователя должно содержать не менее 2 символов.");
            }
            if (age < 18 || age > 120)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Возраст должен быть в диапазоне от 18 до 120 лет.");
            }
            Console.WriteLine($"Пользователь {username} (возраст: {age} успешно зарегистрирован.)");
        }

    }
}
