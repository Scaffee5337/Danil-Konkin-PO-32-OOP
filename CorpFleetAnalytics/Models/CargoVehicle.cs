using System;
using System.Collections.Generic;
using System.Text;

namespace CorpFleetAnalytics.Models
{
    public class CargoVehicle : Vehicle
    {
        public double MaxLoadTon { get; private set; }
        public CargoVehicle(int id,string model,int power,double basePrice,Category category,double maxLoadTon) : base(id, model, power, basePrice, category)
        {
            if (maxLoadTon <= 0) throw new ArgumentException("Грузоподъёмность должна быть положительной.");
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
    }
}
