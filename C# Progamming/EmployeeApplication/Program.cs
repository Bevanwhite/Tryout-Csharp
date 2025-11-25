using System;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeId = 0;
            string firstName = string.Empty;
            string lastName = string.Empty;
            decimal annualSalary = 0;
            char gender = '\0';
            bool isManager = false;

            Console.WriteLine("Please enter a unique Id for this employee");

            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the employee's first name");

            firstName = Console.ReadLine();

            Console.WriteLine("Please enter the employee's last Name");

            lastName = Console.ReadLine();

            Console.WriteLine("Please enter the employee's annual Salary");

            annualSalary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the employee's gender ('f' = female, 'm' = male)");

            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please enter is a manager (true/false)");

            isManager = Convert.ToBoolean(Console.ReadLine());

            string genderTerm = (gender == 'f') ? "female" : "male";
            string managerNarrative = (isManager)
            ? "part of the management team"
            : "currently not part of the management team";

            string narrative = $"Employee with an Id of {employeeId}";
            narrative += $"who's full name is {firstName} {lastName}{Environment.NewLine}";
            narrative += $"is a {genderTerm} employee who is {managerNarrative}.{Environment.NewLine}";
            narrative += $"This employee earns an annual salary of {annualSalary} pounds.";

            Console.Clear();

            Console.WriteLine(narrative);

            Console.ReadKey();
        }
    }
}
