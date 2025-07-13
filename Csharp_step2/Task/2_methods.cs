using System;


class Methods_2
{
    //2.Prepare the class with 10 different methods Each method return type should be same(any) but different parameters

    static void Main()
    {
        Console.WriteLine("------Swapna Details--------");
        bool personType = GetPersonType();
        Console.WriteLine($"personType(isStudent): {personType}");

        string studentName = StudentName();
        Console.WriteLine(studentName);

        int ageDetails = GetStudentAge();
        Console.WriteLine($"age: {ageDetails}");

        double mcetRank = GetMcetRank();
        Console.WriteLine($"Swapna secured {mcetRank} rank in her Mcet examination");

        string CourseDetails = GetStudentCourse();
        Console.WriteLine(CourseDetails);

        string college = StudentCollege();
        Console.WriteLine(college);

        string Branch = GetBranch("ECE");
        Console.WriteLine(Branch);

        byte studentPercentage = GetPercentage(91);
        Console.WriteLine($"Percentage: {studentPercentage}");

        short subjectsCount = GetsubjectsCount();
        Console.WriteLine($"number of subjects: {subjectsCount}");

        string Location = CollegeLocation("Kadapa");
        Console.WriteLine(Location);
    }

    static bool GetPersonType()
    {
        bool isStudent = true;
        return isStudent;
    }

    static string StudentName()
    {
        string name = "Swapna";
        return $"Student Name: {name}";
    }

    static int GetStudentAge()
    {

        int age = 20;
        return age;
    }

    static double GetMcetRank()
    {
        double rank = 40510.67;
        return rank;
    }
    static string GetStudentCourse()
    {
        string Course = "BTech";
        return $"Course: {Course}";
    }

    static string StudentCollege()
    {
        string College = "KSRMCE";
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

    static short GetsubjectsCount()
    {
        short noofSubjects = 40;
        return noofSubjects;
    }

    static string CollegeLocation(string location)
    {
        return $"College location: {location}";
    }


}
