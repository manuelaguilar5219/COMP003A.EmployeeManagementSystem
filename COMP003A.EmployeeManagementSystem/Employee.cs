﻿using System;
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

        public Employee(string employeeId, string firstName, string middleName, string lastName, double salary)
        {
            _employeeId = employeeId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Salary = salary;
        }
        public string EmployeeId
        {
            get { return _employeeId; }
        }
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
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
            }
        }
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
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.Write($"Name: ");
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary:N2}");
        }
    }
}
