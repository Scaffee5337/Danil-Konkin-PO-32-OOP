using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeMaster_Console.Models;

public class DevicePassport : ICloneable
{
    public string Manufacturer { get; set; } = string.Empty;

    public string SerialNumber { get; set; } = string.Empty;

    public DateTime CalibrationDate { get; set; }

    public object Clone()
    {
        return MemberwiseClone();
    }
}
