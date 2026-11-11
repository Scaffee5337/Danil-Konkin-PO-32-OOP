using System;
using System.Collections.Generic;
using System.Text;

namespace Indexatory
{
     public class CompanyCatalog
    {
        private Person[] staff;
        public CompanyCatalog(Person[] people) => staff = people;
        public Person this[int index] { get => staff[index]; set => staff[index] = value; }
        public Person this[string name]
        {
            get
            {
                foreach (var p in staff) if (p.Name == name) return p;
                throw new KeyNotFoundException("Сотрудник не найден");
            }
        }
    }
}
