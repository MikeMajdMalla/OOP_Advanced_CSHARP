using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentInCSharp
{
    public class Programmer : Employee
    {
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
        // I used a List as a data structure, so I don't need to specify the size of the list in advance,
        // making it easy to add mentees as needed
        // In addition, it provides better performance.
        // This results in faster operations and better memory utilization compared to fixed-size arrays or other data structures.
        public List<Mentee> Mentees { get; set; } = new List<Mentee>();

        public Programmer Mentor { get; set; } 

        public Programmer(string firstName, string lastName, int payroll, double basicSalary, string languageType)
            : base(firstName, lastName, payroll, basicSalary)
        {
            ProgrammingLanguage = new ProgrammingLanguage(languageType);
           
           
        }

        public override double GetSalary()
        {
            double enhancedSalary = BasicSalary;

            if (ProgrammingLanguage.LanguageType == "C#")
            {
                enhancedSalary += 0.10 * BasicSalary;
            }

            return enhancedSalary;
        }

        public void AddMentee(Mentee mentee)
        {
            Mentees.Add(mentee);
            mentee.Mentor = this;

            // Increment the mentor's salary by 5% for each mentee
            double mentorSalaryIncrement = 0.05 * mentee.GetSalary();
            BasicSalary += mentorSalaryIncrement;
        }

        public override string ToString()
        {
            string info = base.ToString();

            if (Mentor != null) { info += $"\n Mentor: {Mentor.FirstName} {Mentor.LastName}"; }
            

            info += $"\nProgramming Language: {ProgrammingLanguage.LanguageType}";

            if (Mentees.Count > 0)
            {
                info += "\nMentees:";
                foreach (var mentee in Mentees)
                {
                    info += $"\n- {mentee.FirstName} {mentee.LastName}";
                }
            }

            return info;
        }


    }

}
