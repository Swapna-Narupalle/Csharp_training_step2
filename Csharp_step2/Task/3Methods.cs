using System;


class Methods_3
{
    //3.Prepare the class with 10 different return methods with different parameters 


    static void Main()
    {
        Console.WriteLine("------Swapna Details--------");
        bool personType = GetPersonType(true);
        Console.WriteLine($"personType(isStudent): {personType}");

        string studentName = StudentName("Swapna");
        Console.WriteLine(studentName);

        int ageDetails = GetStudentAge(20);
        Console.WriteLine($"age: {ageDetails}");

        double mcetRank = GetMcetRank(40510.67);
        Console.WriteLine($"Swapna secured {mcetRank} rank in her Mcet examination");

        string CourseDetails = GetStudentCourse("BTech");
        Console.WriteLine(CourseDetails);

        string college = StudentCollege("KSRMCE");
        Console.WriteLine(college);

        string Branch = GetBranch("ECE");
        Console.WriteLine(Branch);

        byte studentPercentage = GetPercentage(91);
        Console.WriteLine($"Percentage: {studentPercentage}");

        short subjectsCount = GetsubjectsCount(40);
        Console.WriteLine($"number of subjects: {subjectsCount}");

        string Location = CollegeLocation("Kadapa");
        Console.WriteLine(Location);
    }

    static bool GetPersonType(bool isStudent)
    {
        
        return isStudent;
    }

    static string StudentName(string name)
    {
        
        return $"Student Name: {name}";
    }

    static int GetStudentAge(int age)
    {
        return age;
    }

    static double GetMcetRank(double rank)
    {
        
        return rank;
    }
    static string GetStudentCourse(string Course)
    {
        
        return $"Course: {Course}";
    }

    static string StudentCollege(string College)
    {
        
        return $"Swapna is Studying her Btech in {College}";
    }

    static string GetBranch(string branch)
    {
        return $"Branch: {branch}";
    }

    static byte GetPercentage(byte Percentage)
    {
        return Percentage;
    }

    static short GetsubjectsCount(short noofSubjects)
    {
        
        return noofSubjects;
    }

    static string CollegeLocation(string location)
    {
        return $"College location: {location}";
    }


}
