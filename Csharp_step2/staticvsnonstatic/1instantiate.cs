using System;


namespace StaticvsNonstatic_instantiate
{
    public static class StaticClass
    {
        public static void Printmessage1()
        {
            Console.WriteLine("This is is static class method");
        }

        public static string Printmessage2()
        {
            return "This is is static class return type method";
        }
    }
    
    public class Nonstaticclass
    {
        public void Printmessage1()
        {
            Console.WriteLine("This is a non static class method");
        }

        public string Printmessage2()
        {
            return "This is a non static class return type method";
        }

        public static void Printmessage3()
        {
            Console.WriteLine("This is a non static class and static method");
        }
    }

    public class Mainprogram
    {
        public static void Main()
        {
            StaticClass.Printmessage1();

            Console.WriteLine(StaticClass.Printmessage2());

            Nonstaticclass nonstaticclass = new Nonstaticclass();

            nonstaticclass.Printmessage1();
            Console.WriteLine(nonstaticclass.Printmessage2());

            Nonstaticclass.Printmessage3();


        }
    }
}
