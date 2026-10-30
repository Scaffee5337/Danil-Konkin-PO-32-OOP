using System;
using System.Collections.Generic;
using System.Text;

namespace CorpFleetAnalytics.Models
{
    public class MaintenanceService
    {
        public int Id { get; private set; }
        public string ServiceName { get; private set; }
        public double Cost { get; private set; }
        public DateTime LogDate { get; private set; }
        public string Channel { get; private set; }
        public MaintenanceService(int id,string serviceName,double cost,DateTime logDate,string channel)
        {
            if (id < 0) throw new ArgumentException("ID не может быть отрицательным.");
            if (string.IsNullOrWhiteSpace(serviceName)) throw new ArgumentException("Название обслуживания обязательно.");
            if (cost < 0) throw new ArgumentException("Стоимость не может быть отрицательной.");
            if (channel != "Online" && channel != "Offline") throw new ArgumentException("Недопустимый канал обслуживания.");
            Id = id;
            ServiceName = serviceName;
            Cost = cost;
            LogDate = logDate;
            Channel = channel;
        }
        public override string ToString()
        {
            return $"{ServiceName} — {Cost:N2} ({Channel})";
        }
    }
}