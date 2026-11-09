using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloadingLab
{
    public class CurrencyRecord
    {
        public string Code {  get; set; }
        public decimal Amount { get; set; }
        public CurrencyRecord(string code, decimal amount)
        {
            Code = code;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"{Amount:F2} {Code}";
        }
    }
}
