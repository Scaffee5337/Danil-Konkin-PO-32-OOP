using System;
using System.Collections.Generic;
using System.Text;

using CorpFleetAnalytics.Interfaces;

namespace CorpFleetAnalytics.Models
{
    public class PassengerVehicle : Vehicle, IExportable
    {
        public PassengerVehicle(int id,string model,int power,double basePrice,Category category): base(id, model, power, basePrice, category)
        {
        }
        public override double CalculateTax()
        {
            return BasePrice * Category.TaxRate / 100.0;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Пассажирское ТС";
        }
        public string GetExportInfo()
        {
            return $"Пассажирский транспорт: {Model}, " +$"Мощность: {Power} л.с., " +$"Стоимость: {BasePrice:N2}.";
        }
        public override object Clone()
        {
            Category clonedCategory = new Category(Category.Id,Category.CategoryName,Category.TaxRate);

            PassengerVehicle clone = new PassengerVehicle(Id,Model,Power,BasePrice,clonedCategory)
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
