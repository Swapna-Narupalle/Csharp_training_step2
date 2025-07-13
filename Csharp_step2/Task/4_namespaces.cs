using StudentDetailsSystem;
using System;

///<summary>
///namespace contain number of classes that shold be static or non static
///</summary>
namespace AllDetails_1
{
    //4. Prepare the single namespace and add the classes

    /// <summary>
    /// Static class contains only static members.
    /// </summary>
    static class EmployeeDetails1//class contain number of constructors
    {
        public static string empName;//static field
        public static int empexperience { get; set; }//static property
        public static string emppackage { get; set; }//static property

        /// <summary>
        /// 1. static constructer does not allow access modifiers(public, private).
        /// 2. static constructer doesn't contain parameters.
        /// 3. we can use only one static constructor in the class
        /// </summary>
       
        static EmployeeDetails1()//static constructor
        {
            empName = "Sreeja";
            empexperience = 2;
            emppackage = "8LPA";
        }

        public static string GetEmpDetails()
        {
            return $"Employee Details:\n Employee Name: {empName}\n Experience: {empexperience}\n Package: {emppackage}";
        }
    }

    //Non-static class contains both static and non-static members.
    class StudentDetails1
    {
        public static string stuName;//static field
        public const int stuAge = 22;// const is implicitly static
        public static DateTime CourseJoiningdate; //static field
        public static string Course { get; set; }//static property
        public byte Percentage { get; set; }//non-static property

        static StudentDetails1()//static constructor
        {
            stuName = "Mounika";
            CourseJoiningdate = new DateTime(2021,12,15);
        }

        public StudentDetails1(string stuCourse, byte stuPercentage)
        {
            Course = stuCourse;
            Percentage = stuPercentage;
        }

        public static string GetStudentDetails()
        {
            StudentDetails1 student = new StudentDetails1("BTech", 91);
            return $"Student Details:\n Student Name: {stuName}\n Age: {stuAge}\n Course Joiningdate: {CourseJoiningdate}\n Course: {Course}\n Percentage: {student.Percentage}";
        }


    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine(EmployeeDetails1.GetEmpDetails());

            Console.WriteLine(StudentDetails1.GetStudentDetails());
        }
    }
}
