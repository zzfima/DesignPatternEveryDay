﻿namespace Prototype.Models
{
    internal class Employee : IEmployeePrototype
    {
        public string? Name { get; set; }
        public string? Department { get; set; }

        public Employee GetClone() => (Employee)MemberwiseClone();
    }
}
