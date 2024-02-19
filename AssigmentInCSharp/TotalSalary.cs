using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentInCSharp
{
    public static class TotalSalary
    {
        public static double CalculateTotalSalary(List<Employee> employees)
        {
            double totalSalary = 0;

            foreach (var employee in employees)
            {
                totalSalary += employee.GetSalary();
            }

            return totalSalary;
        }
    }

}
