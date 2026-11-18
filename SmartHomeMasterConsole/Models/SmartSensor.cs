using SmartHomeMasterConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeMasterConsole.Models;

public class SmartSensor : Device
{
    public double Accuracy { get; private set; }
    public SmartSensor(int id, string model, double power, double accuracy) : base(id, model, power)
    {
        Accuracy = accuracy;
    }
    public override string GetStatus()
    {
        return _isActive ? "Датчик работает" : "Датчик отключен";
    }
    public override double CalculatePowerConsumption()
    {
        return _isActive ? Power : 0;
    }
    public new string GetDeviceInfo()
    {
        return $"Датчик: {Model}, ID: {Id}, " + $"Точность: {Accuracy}%";
    }
}
