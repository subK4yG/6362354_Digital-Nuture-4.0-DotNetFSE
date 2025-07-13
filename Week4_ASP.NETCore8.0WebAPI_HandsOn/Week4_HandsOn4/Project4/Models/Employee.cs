using System;
using System.Collections.Generic;

namespace Project4.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
        public bool Permanent { get; set; }
        public Department Department { get; set; } = new();
        public List<Skill> Skills { get; set; } = new();
        public DateTime DateOfBirth { get; set; }
    }
}
