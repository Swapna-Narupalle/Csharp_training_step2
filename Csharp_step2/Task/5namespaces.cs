using System;

//5. Prepare the different namespaces with single class

namespace MovieDetails_System
{
    class MovieDetails
    {
        public static string movieName;
        public static string movieDirector;
        public static string movieActor { get; set; }
        static MovieDetails()
        {
            movieName = "Devara";
            movieDirector = "Koratala siva";
            movieActor = "NTR";
        }
        public string GetMovieDetails()
        {
            return $"Movie Details:\n movie Name: {movieName}\n Director name: {movieDirector}\n Actor name: {movieActor}";
        }
    }
}
namespace StudentDetails_System
{
    static class StudentDetails
    {
        public static string stuName;
        public static int stuAge;
        public static string Course;

        static StudentDetails()
        {
            stuName = "Madhu";
            stuAge = 20;
            Course = "BTech";
        }
        public static string GetStudentDetails()
        {
            return $"Student Details:\n Student name: {stuName}\n Age: {stuAge}\n Course: {Course}";
        }
    }
}
namespace EmployeeDetails_System
{
    class EmployeeDetails
    {
        public string empName;
        public int experience;
        public string jobName;
        public EmployeeDetails(string Name, int exp, string JobName)
        {
            empName = Name;
            experience = exp;
            jobName = JobName;
        }
        public string GetEmpDetails()
        {
            
            return $"Employee Details:\n empName: {empName}\n experience: {experience}\n Profession: {jobName}";
        }
    }
}
namespace Main_Program
{
    using MovieDetails_System;
    //using StudentDetails_System;
    //using EmployeeDetails_System;

    class Program
    {
        static void Main()
        {
            MovieDetails movieDetails = new MovieDetails();
            Console.WriteLine(movieDetails.GetMovieDetails());

            //Console.WriteLine(StudentDetails.GetStudentDetails());
            string studentdetails = StudentDetails_System.StudentDetails.GetStudentDetails();
            Console.WriteLine(studentdetails);

            // EmployeeDetails employeedetails = new EmployeeDetails("Rushi", 5, "Software engineer");
            //Console.WriteLine(employeedetails.GetEmpDetails());
            EmployeeDetails_System.EmployeeDetails employeedetails = new EmployeeDetails_System.EmployeeDetails("Rushi", 5, "Software engineer");
            Console.WriteLine(employeedetails.GetEmpDetails());
        }
    }
}
