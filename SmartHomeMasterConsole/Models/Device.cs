using SmartHomeMasterConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeMasterConsole.Models;

public abstract class Device : IExportable, IComparable<Device>, ICloneable
{
    public int Id { get; private set; }
    public string Model { get; private set; }
    public double Power { get; private set; }
    public DevicePassport Passport { get; protected set; }
    protected bool _isActive;
    protected Device(int id, string model, double power)
    {
        Id = id;
        Model = model;
        Power = power;
        _isActive = false;
        Passport = new DevicePassport();
    }
    public virtual string GetStatus()
    {
        return _isActive ? "Активно" : "Неактивно";
    }
    public abstract double CalculatePowerConsumption();
    public string GetDeviceInfo()
    {
        return $"Устройство: {Model}, ID: {Id}";
    }
    public override string ToString()
    {
        return $"ID: {Id}, Модель: {Model}, " + $"Мощность: {Power} Вт, " + $"Статус: {GetStatus()}";
    }
    public override bool Equals(object? obj)
    {
        return obj is Device device && Id == device.Id && Model == device.Model;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Model);
    }
    public void Activate()
    {
        _isActive = true;
    }
    public void Deactivate()
    {
        _isActive = false;
    }
    string IExportable.GetExportData()
    {
        return $"{Id};{Model};{Power};{GetStatus()}";
    }
    public int CompareTo(Device? other)
    {
        if (other is null) return 1;
        return Power.CompareTo(other.Power);
    }
    public virtual object Clone()
    {
        var clone = (Device)MemberwiseClone();
        clone.Passport = (DevicePassport)Passport.Clone();
        return clone;
    }
}
