using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    public abstract class Department
    {
        /// <summary>
        /// Auto-implemented property
        /// </summary>
        public string DepartmentName { get; set; }

        public abstract string GetDepartmentDetails();

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
            Console.WriteLine($"Details: {GetDepartmentDetails()}");
        }
    }

    /// <summary>
    /// HR Department class
    /// </summary>
    public class HRDepartment : Department, IDepartmentOperations
    {
        public HRDepartment()
        {
            DepartmentName = "Human Resources";
        }

        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }

        public void Operate()
        {
            Console.WriteLine("Performing HR operations...");
        }
    }
    public class ITDepartment : Department, IDepartmentOperations
    {
        public ITDepartment()
        {
            DepartmentName = "IT";
        }

        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure.";
        }

        public void Operate()
        {
            Console.WriteLine("Perforiming IT operations");
        }
    }

    public interface IDepartmentOperations
    {
        void Operate();
    }
}
