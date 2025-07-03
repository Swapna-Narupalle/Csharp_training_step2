using MovieDetailsSystem;
//using StudentDetailsSystem;
using EmployeeDetailsSystem;
using System;

namespace MainProgramSystem
{
    class MainProgram
    {
        public static void Main()
        {
            Movie_Name moviename = new Movie_Name();
            Movie_Actor movieactor = new Movie_Actor();
            Console.WriteLine($"{movieactor.MovieActor} acted in {moviename.MovieName} movie");


            StudentDetailsSystem.Student_Name studentname = new StudentDetailsSystem.Student_Name();
            StudentDetailsSystem.Student_Course studentcourse = new StudentDetailsSystem.Student_Course();
            Console.WriteLine($"{studentname.StudentName} has completed her {studentcourse.StudentCourse} from KSRM College of engineering");


            Emp_Name empname = new Emp_Name();
            Emp_Experiece experiece = new Emp_Experiece();
            Console.WriteLine($"{empname.EmpName} has {experiece.EmpExperience} years of experience in the IT industry");

        }
    }
}
