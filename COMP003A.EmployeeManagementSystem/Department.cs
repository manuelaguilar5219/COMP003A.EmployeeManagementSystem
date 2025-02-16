using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// An abstract class named Department
    /// </summary>
    public abstract class Department
    {
        /// <summary>
        /// Gets and sets DepartmentName property
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// Abstract method that will return department details
        /// </summary>
        /// <returns>Returns a string(department details)</returns>
        public abstract string GetDepartmentDetails();
        /// <summary>
        /// Method that displays the department info
        /// </summary>
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
        /// <summary>
        /// Sets DepartmentName as Human Resources in the HRDepartment class
        /// </summary>
        public HRDepartment()
        {
            DepartmentName = "Human Resources";
        }
        /// <summary>
        /// Provides the HRDepartment details
        /// </summary>
        /// <returns>A string that describes what is done in the HR department.</returns>
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }
        /// <summary>
        /// Performs HR operations
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performing HR operations...");
        }
    }
    /// <summary>
    /// ITDepartment class
    /// </summary>
    public class ITDepartment : Department, IDepartmentOperations
    {
        /// <summary>
        /// Sets DepartmentName as IT in the ITDepartment class
        /// </summary>
        public ITDepartment()
        {
            DepartmentName = "IT";
        }
        /// <summary>
        /// Provides IT department details
        /// </summary>
        /// <returns>A string that describes what is done in the IT department operations.</returns>
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure.";
        }
        /// <summary>
        /// Performs IT operations
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Perforiming IT operations");
        }
    }
    /// <summary>
    /// Interface for department operations of each department
    /// </summary>
    public interface IDepartmentOperations
    {
        /// <summary>
        /// Operate method that operates specifically to the dapartment it is in.
        /// </summary>
        void Operate();
    }
}
