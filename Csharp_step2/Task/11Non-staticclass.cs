using StudentDetailsSystem;
using System;

//11.Prepare the example with non-static class and add static members

class StudentDetails2
{
    //Non-static class contains both static and non-static members.

    public static string stuName;//static field
    public const int stuAge = 22;// const is implicitly static
    public static DateTime CourseJoiningdate; //static field
    public static string Course { get; set; }//static property
    public byte Percentage { get; set; }//non-static property

    static StudentDetails2()//static constructor
    {
        stuName = "Mounika";
        CourseJoiningdate = new DateTime(2021, 12, 15);
    }

    public StudentDetails2(string stuCourse, byte stuPercentage)
    {
        Course = stuCourse;
        Percentage = stuPercentage;
    }

    public static string GetStudentDetails()//static method
    {
        StudentDetails2 student = new StudentDetails2("BTech", 91);
        return $"Student Details:\n Student Name: {stuName}\n Age: {stuAge}\n Course Joiningdate: {CourseJoiningdate}\n Course: {Course}\n Percentage: {student.Percentage}";
    }

    static void Main()
    {
        Console.WriteLine(GetStudentDetails());
    }


}


