using System;


namespace Class_inheritence
{
    class School
    {
        public string schoolName;
        public School()
        {
            schoolName = "Sri vedavyasa High School";
            Console.WriteLine($"*********{schoolName}*************");
        }

    }

    class HeadMaster: School
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

    class Student: School
    {
        public string StudentName { get; set; }

        public Student()
        {
           StudentName = "Rushi";
            Console.WriteLine($"{StudentName} is studying his tenth class in {schoolName}");
        }

        public override string ToString()
        {
            return $"Student Name: {StudentName}, School: {schoolName}";
        }
    }

    class program
    {
        static void Main()
        {
            School school = new School();
            Console.WriteLine();

            HeadMaster headmaster1 = new HeadMaster("Narasimha");
            Console.WriteLine();

            HeadMaster headmaster2 = new HeadMaster();
            Console.WriteLine();

            Student student = new Student();
            Console.WriteLine(student);
        }
    }
}
