using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        //public override bool Equals(object? obj)
        //{
        //    Employee employee = (Employee)obj;
        //    return Id == employee.Id && Name == employee.Name && Age == employee.Age && Salary == employee.Salary;
        //}

        public bool Equals(Employee? other)
        {
            return Id == other.Id && Name == other.Name && Age == other.Age && Salary == other.Salary;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
