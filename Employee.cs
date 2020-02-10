using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AzureRedisCacheApi
{
    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string EmployeeId, string Name, int Age)
        {
            this.Id = EmployeeId;
            this.Name = Name;
            this.Age = Age;
        }
    }
}
