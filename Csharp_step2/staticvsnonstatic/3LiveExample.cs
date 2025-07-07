using System;
using System.Data.Common;

namespace Employee_Background
{
    /// <summary>
    /// 1.non static class contain both static and non-static members.
    /// 2.Static constructors can only be created once and are parameterless.
    /// </summary>
    public class EmployeeDetails
    {
        //static members
        public static string empName;
        public static string workLocation;
        public static int empExperience;
        public static string currentPackage;

        static EmployeeDetails()
        {
            Console.WriteLine("enter empName:");
            empName = Console.ReadLine();
            Console.WriteLine(empName);
        }

        public static void Empdetails(string location, int experience, string package)
        {
            workLocation = location;
            empExperience = experience;
            currentPackage = package;
        }

        //Non-static members
        public string EmpName { get; set; }
        public string WorkLocation { get; set; }
        public int EmpExperience { get; set; }
        public string CurrentPackage { get; set; }
        
        //Non-static constructor with parameterless
        public EmployeeDetails()
        {
            Console.WriteLine("Non-static default constructor called.");
        }

        //Non-static constructor with parameter
        public EmployeeDetails(string empname)
        {
            this.EmpName = empname;//we can remove this also
            Console.WriteLine($"Employee name is: {EmpName}");
        }

        public void Empdetails2(string location, int experience, string package)
        {
            WorkLocation = location;
            EmpExperience = experience;
            CurrentPackage = package;
        }

    }
    public class MainProgram
    {
        public static void Main()
        {
            //static members output: we cannot create any instance for static members expect constructor
            Console.WriteLine("**************Employee-1 Details****************");
            EmployeeDetails empdetails1 = new EmployeeDetails();//we can call constructor by using instance(static or non-static)
            EmployeeDetails.Empdetails("Hyderabad", 3, "8LPA");
            Console.WriteLine($"Employee Details:\n EmployeeName: {EmployeeDetails.empName}\n Location: {EmployeeDetails.workLocation}\n Experience: {EmployeeDetails.empExperience}\n package: {EmployeeDetails.currentPackage}");

            //non static members output
            Console.WriteLine("**************Employee-2 Details****************");
            EmployeeDetails empdetails2 = new EmployeeDetails("Mouni");
            empdetails2.Empdetails2("Bangalore", 2, "6LPA");
            Console.WriteLine($"Employee Details:\n EmployeeName: {empdetails2.EmpName}\n Location: {empdetails2.WorkLocation}\n Experience: {empdetails2.EmpExperience}\n package: {empdetails2.CurrentPackage}");

        }
    }
}
