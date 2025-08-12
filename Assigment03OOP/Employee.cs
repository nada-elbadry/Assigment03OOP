using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03OOP
{
    class Employee
    {
        #region Properties

        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        #endregion


        #region Constructor
        public Employee(int id, string name, Gender gender, SecurityLevel securityLevel, double salary, HiringDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, " +
                   $"Security: {SecurityLevel}, Salary: {string.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}, " +
                   $"Hire Date: {HireDate}";
        } 
        #endregion
    }
}
