using System;



//7.Write the example on Inheritance

namespace Inheritance
{
    class School
    {
        public string schoolName;
        public School()
        {
            schoolName = "Sri vedavyasa High School";

        }

        public School(string student)
        {
            schoolName = "Sri vedavyasa High School";
            Console.WriteLine($"{student} is the topper of the {schoolName}");
        }

    }

    class HeadMaster : School
    {
        public string headMaster;
        public HeadMaster(string Name)
        {
            headMaster = Name;
            Console.WriteLine($"The headMaster of the school is: {headMaster}");
        }

        public HeadMaster()
        {

            Console.WriteLine($"Iam working as a HeadMaster in {schoolName}");
        }
    }

    class Student : School
    {
        public string StudentName { get; set; }

        public Student() : base("Rushi")
        {
            StudentName = "Rushi";
            Console.WriteLine($"{StudentName} is studying his tenth class in {schoolName}");
        }

        public override string ToString()
        {
            return $"Student Name: {StudentName}, School: {schoolName}";
        }
    }

    class program_inheritance
    {
        static void Main()
        {
            School school1 = new School();
            Console.WriteLine($"*********{school1.schoolName}*************");

            School school2 = new School();


            HeadMaster headmaster1 = new HeadMaster("Rami reddy");


            HeadMaster headmaster2 = new HeadMaster();


            Student student = new Student();
            Console.WriteLine(student);
        }
    }
}

