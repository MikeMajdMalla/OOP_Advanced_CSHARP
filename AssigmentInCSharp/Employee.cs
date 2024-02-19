using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentInCSharp
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Payroll { get; set; }
        public double BasicSalary { get; set; }

        public Employee(string firstName, string lastName, int payroll, double basicSalary)
        {
            if (basicSalary >= 100000)
            {
                throw new Exception($"Could not create employee {firstName} {lastName} because the salary is too high.");
            }
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException($"First name and last name {firstName} {lastName} must not be empty.");
            }
            FirstName = firstName;
            LastName = lastName;
            Payroll = payroll;
            BasicSalary = basicSalary;
        }

        public virtual double GetSalary()
        {
            return BasicSalary;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Payroll: {Payroll}, Salary: {GetSalary()}";
        }

        public string copyRight()
        {
            return "******* All rights are reserved!*******";
        }




    }
}
