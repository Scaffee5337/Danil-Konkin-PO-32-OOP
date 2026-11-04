using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicCRM.Models
{
    public abstract class MedicalEmployee : IComparable
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public decimal BaseSalary { get; private set; }
        protected MedicalEmployee(int id, string fullName, decimal baseSalary)
        {
            if (id < 0) throw new ArgumentException("ID не может быть отрицательным.");
            if (string.IsNullOrWhiteSpace(fullName)) throw new ArgumentException("ФИО сотрудника не может быть пустым.");
            if (baseSalary < 0) throw new ArgumentException("Оклад не может быть отрицательным.");
            Id = id;
            FullName = fullName;
            BaseSalary = baseSalary;
        }
        public virtual string GetInfo()
        {
            return $"Сотрудник: {FullName}, ID: {Id}, Оклад: {BaseSalary}";
        }
        public abstract decimal CalculateMonthlyPayout(int appointmentsCount);
        public override string ToString()
        {
            return $"{FullName} | ID: {Id} | Оклад: {BaseSalary}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is MedicalEmployee other)
            {
                return Id == other.Id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public int CompareTo(object? obj)
        {
            if (obj is null) return -1;
            if (obj is not MedicalEmployee other) throw new ArgumentException("Объект должен быть типа MedicalEmployee.");
            return other.BaseSalary.CompareTo(BaseSalary);
        }
    }
}
