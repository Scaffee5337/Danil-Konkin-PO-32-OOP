using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloadingLab
{
    public class Money
    {
        public int Rubles { get; set; }
        public int Kopeks { get; set; }
        public Money(int rubles, int kopeks)
        {
            Rubles = rubles;
            Kopeks = kopeks;
        }
        private void Normalize(int rubles, int  kopeks)
        {
            long totalKopeks = (long)rubles * 100 + kopeks;
            long normalizedRubles = totalKopeks / 100;
            long normalizedKopeks = totalKopeks % 100;
            if (normalizedKopeks < 0)
            {
                normalizedRubles--;
                normalizedKopeks += 100;
            }
            Rubles = checked((int)normalizedRubles);
            Kopeks = (int)normalizedKopeks;
        }
        public override string ToString()
        {
            return $"{Rubles} руб. {Kopeks:D2} коп.";
        }
        private long TotalKopeks => (long)Rubles * 100 + Kopeks;
        private static Money FromTotalKopeks(long total)
        {
            long rubles = total / 100;
            long kopeks = total % 100;
            return new Money(checked((int)rubles), checked((int)kopeks)
            );
        }
        public static Money operator +(Money a, Money b)
        {
            return FromTotalKopeks(checked(a.TotalKopeks + b.TotalKopeks)
            );
        }
        public static Money operator -(Money a, Money b)
        {
            return FromTotalKopeks(checked(a.TotalKopeks - b.TotalKopeks)
            );
        }
        public static Money operator +(Money a, int rubles)
        {
            return FromTotalKopeks(checked(a.TotalKopeks + (long)rubles * 100)
            );
        }
        public static bool operator >(Money a, Money b) => a.TotalKopeks > b.TotalKopeks;
        public static bool operator <(Money a, Money b)=> a.TotalKopeks < b.TotalKopeks;
        public static bool operator ==(Money a, Money b) => a.TotalKopeks == b.TotalKopeks;
        public static bool operator !=(Money a, Money b)=> !(a == b);
        public static bool operator true(Money m) => m.TotalKopeks > 0;
        public static bool operator false(Money m) => m.TotalKopeks <= 0;
        public static bool operator !(Money m)=> m.TotalKopeks <= 0;
        public override bool Equals(object? obj)
        {
            return obj is Money other && this == other;
        }
        public override int GetHashCode()
        {
            return TotalKopeks.GetHashCode();
        }
    }
}
