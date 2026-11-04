using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicCRM.Models
{
    public class MedicalLicense
    {
        public string LicenseNumber { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public MedicalLicense(string licenseNumber, DateTime expirationDate)
        {
            if (string.IsNullOrWhiteSpace(licenseNumber)) throw new ArgumentException("Номер лицензии не может быть пустым.");
            LicenseNumber = licenseNumber;
            ExpirationDate = expirationDate;
        }
    }
}
