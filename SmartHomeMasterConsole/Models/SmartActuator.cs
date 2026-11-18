using SmartHomeMasterConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeMaster_Console.Models;

public class SmartActuator : Device
{
    public double LoadCapacity { get; private set; }
    public SmartActuator(int id, string model, double power, double loadCapacity) : base(id, model, power)
    {
        LoadCapacity = loadCapacity;
    }
    public override string GetStatus()
    {
        return _isActive ? "Исполнительное устройство включено" : "Исполнительное устройство отключено";
    }
    public override double CalculatePowerConsumption()
    {
        return _isActive ? Power : 0;
    }
}
