using CorpFleetAnalytics.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorpFleetAnalytics.Models
{
    public abstract class Vehicle : IStorable, IComparable, ICloneable
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public int Power { get; private set; }
        public double BasePrice { get; private set; }
        public Category Category { get; private set; }
        public List<MaintenanceService> MaintenanceServices { get; private set; }
        public string FilePath { get; set; } = string.Empty;
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is not Vehicle other) throw new ArgumentException("Объект должен быть типа Vehicle.");
            return BasePrice.CompareTo(other.BasePrice);
        }
        public void Save()
        {
            if (string.IsNullOrWhiteSpace(FilePath)) throw new InvalidOperationException("Путь сохранения не указан.");
            File.WriteAllText(FilePath, ToString());
        }
        public abstract object Clone();
        protected Vehicle(int id,string model,int power,double basePrice,Category category)
        {
            if (id < 0) throw new ArgumentException("ID не может быть отрицательным.");
            if (string.IsNullOrWhiteSpace(model)) throw new ArgumentException("Модель транспортного средства обязательна.");
            if (power <= 0) throw new ArgumentException("Мощность должна быть положительной.");
            if (basePrice <= 0) throw new ArgumentException("Стоимость должна быть положительной.");
            Category = category ?? throw new ArgumentNullException(nameof(category));
            Id = id;
            Model = model;
            Power = power;
            BasePrice = basePrice;
            MaintenanceServices = new List<MaintenanceService>();
        }
        public abstract double CalculateTax();
        public void AddMaintenanceService(MaintenanceService service)
        {
            if (service == null) throw new ArgumentNullException(nameof(service));
            MaintenanceServices.Add(service);
        }
        public override string ToString()
        {
            return $"{Model} | {Power} л.с. | {BasePrice:N2}";
        }
        public override bool Equals(object obj)
        {
            if (obj is not Vehicle other) return false;
            return Model == other.Model && Power == other.Power;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Model, Power);
        }
    }
}
