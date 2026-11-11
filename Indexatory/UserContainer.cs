using System;
using System.Collections.Generic;
using System.Text;

namespace Indexatory
{
    class UserContainer
    {
        private string name;
        private string email;
        private string role;
        public UserContainer(string name, string email, string role)
        {
            this.name = name;
            this.email = email;
            this.role = role;
        }
        public string this[string fieldName]
        {
            get
                {
                return fieldName.ToLower() switch
                {
                    "name" => name,
                    "email" => email,
                    "role" => role, _ => throw new ArgumentException($"Поле '{fieldName}' не существует")
                };
            }
        }
    }
}
