using System;
using System.Collections.Generic;
using System.Text;

using CorpFleetAnalytics.Interfaces;

namespace CorpFleetAnalytics.Models
{
    public class CargoVehicle : Vehicle, IExportable
    {
        public double MaxLoadTon { get; private set; }
        public CargoVehicle(int id,string model,int power,double basePrice,Category category,double maxLoadTon) : base(id, model, power, basePrice, category)
        {
            if (maxLoadTon <= 0)throw new ArgumentException("Грузоподъёмность должна быть положительной.");
            MaxLoadTon = maxLoadTon;
        }
        public override double CalculateTax()
        {
            return BasePrice * Category.TaxRate / 100.0;
        }
        public override string ToString()
        {
            return $"{base.ToString()} | Грузоподъёмность: {MaxLoadTon} т.";
        }
        string IExportable.GetExportInfo()
        {
            return $"Грузовой транспорт: {Model}, " + $"Мощность: {Power} л.с., " +$"Стоимость: {BasePrice:N2}, " + $"Грузоподъёмность: {MaxLoadTon} т.";
        }
        public override object Clone()
        {
            Category clonedCategory = new Category(Category.Id,Category.CategoryName,Category.TaxRate);

            CargoVehicle clone = new CargoVehicle(Id,Model,Power,BasePrice,clonedCategory,MaxLoadTon)
            {
                FilePath = FilePath
            };

            foreach (MaintenanceService service in MaintenanceServices)
            {
                clone.AddMaintenanceService(
                    new MaintenanceService(
                        service.Id,
                        service.ServiceName,
                        service.Cost,
                        service.LogDate,
                        service.Channel));
            }
            return clone;
        }
    }
}
