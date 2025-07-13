using System;
//6. Prepare the different namespaces with different classes
namespace EmployeeNamespace
{
    public class Employee//non-static class
    {
        public string Name { get; set; }//non-static property
        public int Experience { get; set; }//non-static property

        public Employee(string name, int experience)//non-static constructor
        {
            Name = name;
            Experience = experience;
        }

        public void Display()//non-static method
        {
            Console.WriteLine($"Employee: {Name}, Experience: {Experience} years");
        }
    }

    public class Salary//non-static class
    {
        public double Package { get; set; }//non-static property

        public Salary(double package)//non-static constructor
        {
            Package = package;
        }

        public void ShowSalary()//non-static method
        {
            Console.WriteLine($"Salary Package: {Package} LPA");
        }
    }
}

namespace StudentNamespace
{
    public class Student//non-static class
    {
        public string Name { get; set; }//non-static property
        public string Course { get; set; }//non-static property

        public Student(string name, string course)//non-static constructor
        {
            Name = name;
            Course = course;
        }

        public void Display()//non-static method
        {
            Console.WriteLine($"Student: {Name}, Course: {Course}");
        }
    }

    public class Marks//non-static class
    {
        public int Percentage { get; set; }//non-static property

        public Marks(int percentage)//non-static constructor
        {
            Percentage = percentage;
        }

        public void ShowMarks()//non-static method
        {
            Console.WriteLine($"Percentage: {Percentage}%");
        }
    }
}

namespace DepartmentNamespace
{
    public class Department//non-static class
    {
        public string DeptName { get; set; }//non-static property

        public Department(string deptName)//non-static constructor
        {
            DeptName = deptName;
        }

        public void ShowDepartment()//non-static method
        {
            Console.WriteLine($"Department: {DeptName}");
        }
    }

    public class Faculty//non-static class
    {
        public string FacultyName { get; set; }//non-static property

        public Faculty(string facultyName)//non-static constructor
        {
            FacultyName = facultyName;
        }

        public void ShowFaculty()//non-static method
        {
            Console.WriteLine($"Head of Department: {FacultyName}");
        }
    }
}

namespace ProgramNamespace
{
    using EmployeeNamespace;
    using StudentNamespace;
    using DepartmentNamespace;

    class Program
    {
        static void Main()
        {
            // Employee-related
            Employee emp = new Employee("Sreeja", 2);
            Salary sal = new Salary(8.5);
            emp.Display();
            sal.ShowSalary();

            Console.WriteLine();

            // Student-related
            Student stu = new Student("Mounika", "BTech");
            Marks mark = new Marks(91);
            stu.Display();
            mark.ShowMarks();

            Console.WriteLine();

            // Department-related
            Department dept = new Department("Computer Science");
            Faculty fac = new Faculty("Dr. Ravi");
            dept.ShowDepartment();
            fac.ShowFaculty();
        }
    }
}