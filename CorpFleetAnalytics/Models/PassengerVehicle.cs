using System;
using System.Collections.Generic;
using System.Text;

namespace CorpFleetAnalytics.Models
{
    public class PassengerVehicle : Vehicle
    {
        public PassengerVehicle(int id, string model, int power, double basePrice, Category category) : base(id, model, power, basePrice, category) { }
        public override double CalculateTax()
        {
            return BasePrice * Category.TaxRate / 100.0;
        }
        public override string ToString()
        {
            return $"{base.ToString()} | Пассажирское ТС";
        }
    }
}
