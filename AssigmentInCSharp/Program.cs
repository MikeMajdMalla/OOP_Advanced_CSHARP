using welcomingMsg;

namespace AssigmentInCSharp
{
    public  delegate string copyR ();
    public class Program
    {
        static void Main(string[] args)
        {
            // here I called the method from the class1 from another project which's called welcomingMsg
            Class1 cls = new Class1();
            Console.WriteLine(cls.Welcoming());

            try
            {
                CreateTestData();
            }
            catch (Exception ex)

            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        private static void CreateTestData()
        {
            // Create programmers
            Programmer programmer1 = new Programmer("Mike", "Almalla", 1, 30000, "C#");
            Programmer programmer2 = new Programmer("Sara", "Johansson", 2, 30000, "Java");
            Programmer programmer5 = new Programmer("Tom", "Quaile", 1, 30000, "C#");
            Programmer programmer6 = new Programmer("Tim", "Hansen", 2, 30000, "Java");
            Programmer programmer3 = new Programmer("Steve", "Vai", 3, 30000, "Java");
            Programmer programmer4 = new Programmer("Joe", "Sateriani", 4, 30000, "C#");

            // These two employees are not programmers, but it illustrates the polymorphism where the object can act in different ways.
            Employee emp1 = new Employee("Mikael", "Åkerfeldt", 77, 40000);
            Employee emp2 = new Employee("Nick", "Johnston", 76, 41000);

            // Create a mentor (mentor1)
            Programmer mentor1 = new Programmer("Andy", "James", 44, 35000, "C#");

            // Create mentees using the Mentee class
            Mentee mentee1 = new Mentee("John", "Petrucci", 55, 30000, "C#");
            Mentee mentee2 = new Mentee("Guthrie", "Govan", 66, 30000, "Java");

            // Assign mentees (mentee1 and mentee2) to the mentor (mentor1)
            mentor1.AddMentee(mentee1);
            mentor1.AddMentee(mentee2);

            var employees = new List<Employee>
            {
              programmer1, programmer2, programmer3, programmer4, emp1, emp2, mentee1, mentee2, mentor1
            };

            // Print employee data
            PrintTestData(employees);
            PrintTotalSalary(employees);

            // delegate method 

            Employee testEmp = new Employee("Samir", "Tahsin", 89, 45000);
            copyR del = new copyR(testEmp.copyRight);

            Console.WriteLine(del());


        }

        private static void PrintTotalSalary(List<Employee> employees)
        {
            // Calculate the total salary bill
            double totalSalary = TotalSalary.CalculateTotalSalary(employees);

            // Display the total salary bill
            Console.WriteLine($"Total Salary Bill: {totalSalary}");

        }

        private static void PrintTestData(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

        }

    }
}