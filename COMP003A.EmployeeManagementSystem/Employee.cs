using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// Employee class with employee information and salary
    /// </summary>
    public class Employee
    {
        private string _employeeId;
        private string _firstName;
        private string _middleName = "";
        private string _lastName;
        private double _salary;
        /// <summary>
        /// Constructor that initializes all fields, applying validation through the properties.
        /// </summary>
        /// <param name="employeeId">The empoloyee's ID</param>
        /// <param name="firstName">The employee's first name</param>
        /// <param name="middleName">The employee's middle name</param>
        /// <param name="lastName">The employees's Last name</param>
        /// <param name="salary">The employee's salary</param>
        public Employee(string employeeId, string firstName, string middleName, string lastName, double salary)
        {
            _employeeId = employeeId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Salary = salary;
        }
        /// <summary>
        /// Gets the employee id only.
        /// </summary>
        public string EmployeeId
        {
            get { return _employeeId; }
        }
        /// <summary>
        /// Gets and sets the employee's fast name. Throws ArgumentException that displays a message that the fast name cannot be blank
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Your first name can't be blank!");
    
                }
                _firstName = value;
            }
        }
        /// <summary>
        /// Gets and sets the employee's middle name. 
        /// </summary>
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
            }
        }
        /// <summary>
        /// Gets and sets the employee's last name. Throws ArgumentException that displays a message that the last name cannot be blank
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Your last name can't be blank!");
                }
                _lastName = value;
            }
        }
        /// <summary>
        /// Gets and sets the Salary. Throws ArgumentException that displays message that the value cannot be less than 0.
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary can't be less than 0!");
                }
                _salary = value;
            }
        }
        /// <summary>
        /// Method that prints the employee's full name.
        /// </summary>
        public void PrintFullName()
        {
            if (string.IsNullOrEmpty(MiddleName))
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }
            else
            {
                Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
            }
        }
        /// <summary>
        /// Method that displays the employee's info.
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.Write($"Name: ");
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary:N2}");
        }
    }
}
