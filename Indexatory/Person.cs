using System;
using System.Collections.Generic;
using System.Text;

namespace Indexatory
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public Person(string name, string position = "Сотрудник")
        {
            Name = name;
            Position = position;
        }
        public override string ToString() => $"{Name} (${Position})";
    }
}
