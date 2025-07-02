using System;

/// <summary>
/// by using property we can control the data
/// get and set are the accessaries of the property
/// by using get cam get the value  
/// by using set we can assign the value
/// </summary>
class StudentDetails
{
    string studentname = "Swapna";
    string studentid = "4B4";
    string course = "BTech";
    string branch = "ECE";

    //we can call properties as a attributes
    string StudentName { get; set; }
    string StudentId { get; set; }
    string Course { get; set; }
    string Branch { get; set; }

    static void Main()
    {
        StudentDetails studentDetails = new StudentDetails();
        studentDetails.StudentName = "Mounika";
        studentDetails.StudentId = "4D9";
        studentDetails.Course = "Deplama";
        studentDetails.Branch = "CSE";

        Console.WriteLine($"studentName is: {studentDetails.StudentName}, Course is: {studentDetails.Course}");
    }
}
