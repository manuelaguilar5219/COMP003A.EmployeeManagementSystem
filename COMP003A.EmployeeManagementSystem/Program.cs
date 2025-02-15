// Author: Manuel Aguilar
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Employee ID: ");
                string employeeId = Console.ReadLine();
                Console.WriteLine("Enter First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Middle Name (Press enter to skip): ");
                string middleName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                Employee employee = new Employee(employeeId, firstName, middleName, lastName, salary);
                
                employee.DisplayEmployeeInfo();
            }
            catch (ArgumentException ex)
            { 
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}