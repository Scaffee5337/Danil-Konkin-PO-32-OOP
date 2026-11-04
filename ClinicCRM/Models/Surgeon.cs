using System;
using System.Collections.Generic;
using System.Text; 

namespace ClinicCRM.Models
{
    public class Surgeon : Doctor
    {
        private int complexOperationsExperience;
        private readonly decimal categoryBonus;
        public Surgeon(int id, string fullName, decimal baseSalary, string category, MedicalLicense license, int complexOperationsExperience, decimal categoryBonus)
            : base(id, fullName, baseSalary, category, license)
        {
            if (complexOperationsExperience < 0) throw new ArgumentException("Стаж не может быть отрицательным.");
            if (categoryBonus < 0) throw new ArgumentException("Премия не может быть отрицательной.");
            this.complexOperationsExperience = complexOperationsExperience;
            this.categoryBonus = categoryBonus;
        }
        public override decimal CalculateMonthlyPayout(int appointmentsCount)
        {
            if (appointmentsCount < 0) throw new ArgumentException("Количество приемов не может быть отрицательным.");
            return BaseSalary
                   + (appointmentsCount * 1200)
                   + categoryBonus;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, стаж сложных операций: " + $"{complexOperationsExperience} лет";
        }
    }
}
