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
            /// <summary>
            /// Tries to create an employee and display employee info and department details.
            /// </summary>
            try
            {
                /// <summary>
                /// Prompts the user for employee information
                /// </summary>
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
                /// <summary>
                /// Created new employee object using constructor from Employee.cs
                /// </summary>
                Employee employee = new Employee(employeeId, firstName, middleName, lastName, salary);
                
                Console.WriteLine("\nEmployee Created Successfully!\n");
                /// <summary>
                /// Displays employee information
                /// </summary>
                employee.DisplayEmployeeInfo();
                Console.WriteLine("");
                /// <summary>
                /// Created new objects using HRDepartment and ITDepartment classes from Department.cs
                /// </summary>
                Department hrDepartment = new HRDepartment();
                Department itdepartment = new ITDepartment();
                /// <summary>
                /// Displays the department information and operations for both HR and IT departments.
                /// </summary>
                hrDepartment.DisplayDepartmentInfo();
                ((IDepartmentOperations)hrDepartment).Operate();
                Console.WriteLine("");
                itdepartment.DisplayDepartmentInfo();
                ((IDepartmentOperations)itdepartment).Operate();
            }
            /// <summary>
            /// Catches any incorrect input and throws ArgumentException message.
            /// </summary>
            catch (ArgumentException ex)
            { 
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}