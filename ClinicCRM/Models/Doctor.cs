using System;
using System.Collections.Generic;
using System.Text;
using ClinicCRM.Interfaces;

namespace ClinicCRM.Models
{
    public class Doctor : MedicalEmployee, IExportable, ICloneable
    {
        public string Category { get; private set; }
        public MedicalLicense License { get; set; }
        public Doctor(int id, string fullName, decimal baseSalary, string category, MedicalLicense license) : base(id, fullName, baseSalary)
        {
            if (category != "Высшая" && category != "Первая") throw new ArgumentException("Недопустимая категория врача.");
            Category = category;
            License = license ?? throw new ArgumentNullException(nameof(license));
        }
        public override decimal CalculateMonthlyPayout(int appointmentsCount)
        {
            if (appointmentsCount < 0)
                throw new ArgumentException("Количество приемов не может быть отрицательным.");
            return BaseSalary + (appointmentsCount * 450);
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, категория: {Category}";
        }
        string IExportable.GetSummary()
        {
            return $"Врач: {FullName}, категория: {Category}, лицензия: {License.LicenseNumber}";
        }
        public virtual object Clone()
        {
            Doctor clone = (Doctor)MemberwiseClone();
            clone.License = new MedicalLicense(License.LicenseNumber, License.ExpirationDate
            );
            return clone;
        }
    }
}
