using System;


namespace StaticandNonstatic_Members
{

    public static class StudentsStaticLogger
    {
        ///<summary>
        ///Each and every member should be static
        ///Log message is for print the Message as well as increase +1 the value
        ///Example : Incaes EmployeesList is 2 the it will return 3
        ///</summary>
        public static int StudentsMessageCount = 0;

        public static void LogMessage(string Message)
        {
            Console.WriteLine($"[LOG] {Message}");
            StudentsMessageCount = StudentsMessageCount + 1;// 1 addition
        }

        public static int GetMessageCount()
        {
            return StudentsMessageCount;//latest studentsList count
        }

    }

    public class StudentsNonstaticLogger
    {
        public int StudentsMessageCount = 0;

        public void LogMessage(string Message)
        {
            Console.WriteLine($"[LOG] {Message}");
            StudentsMessageCount ++ ; // 1 addition
        }

        public int GetMessageCount()
        {
            return StudentsMessageCount;//latest studentsList count
        }

    }

    public class MainProgram
    {
        public static void Main()
        {
            //static: Iam not create any instance.
            StudentsStaticLogger.LogMessage("Swapna secured 99 marks in her academics");
            StudentsStaticLogger.LogMessage("Mouni secured 85 marks in her academics");
            StudentsStaticLogger.LogMessage("Sandya secured 89 marks in her academics");
            Console.WriteLine($"Total static log Messages: {StudentsStaticLogger.GetMessageCount()}");//3

            //Nonstatic: Here iam creating instances.
            StudentsNonstaticLogger instance1 = new StudentsNonstaticLogger();
            instance1.LogMessage("Sindhu secured First Rank in EAMCET exam");
            instance1.LogMessage("Madhu secured Second Rank in EAMCET exam");

            StudentsNonstaticLogger instance2 = new StudentsNonstaticLogger();
            instance2.LogMessage("yamini secured First Rank in EAMCET exam");

            Console.WriteLine($"Total non static messages from instance1: {instance1.GetMessageCount()}");//2
            Console.WriteLine($"Total non static messages from instance2: {instance2.GetMessageCount()}");//1




        }
    }
}
