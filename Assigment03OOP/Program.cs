using Assigment03OOP;
using System;
using System.Globalization;

#region Library Management Classes

#endregion

class Program
{
    static void Main()
    {
        #region Employees Array
        Employee[] EmpArr = new Employee[3];
        EmpArr[0] = new Employee(1, "Ali", Gender.M, SecurityLevel.DBA, 15000, new HiringDate(5, 3, 2020));
        EmpArr[1] = new Employee(2, "Sara", Gender.F, SecurityLevel.Guest, 8000, new HiringDate(12, 7, 2021));
        EmpArr[2] = new Employee(3, "Omar", Gender.M, SecurityLevel.FullAccess, 20000, new HiringDate(1, 1, 2019));

        Console.WriteLine("Employees before sorting:");
        foreach (var emp in EmpArr)
            Console.WriteLine(emp);

        Array.Sort(EmpArr, (e1, e2) => e1.HireDate.CompareTo(e2.HireDate));

        Console.WriteLine("\nEmployees after sorting by Hire Date:");
        foreach (var emp in EmpArr)
            Console.WriteLine(emp);
        #endregion

        #region Library Management
        Console.WriteLine("\nLibrary Management System:");
        Book book1 = new EBook("C# Basics", "John Doe", "12345", 5.6);
        Book book2 = new PrintedBook("OOP Principles", "Jane Smith", "67890", 320);

        Console.WriteLine(book1);
        Console.WriteLine(book2);
        #endregion
    }
}
