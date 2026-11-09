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
    }
}
