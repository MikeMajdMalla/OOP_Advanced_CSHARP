using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentInCSharp
{
    public  class Mentee : Programmer
    {
        public Mentee(string firstName, string lastName, int payroll, double basicSalary, string languageType)
       : base(firstName, lastName, payroll, basicSalary, languageType)
        {
            
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += "\nRole: Mentee"; // You can add more specific information here if needed.
            return info;
        }



    }
}
