using System;

//15. Example on Method Overriding     - Real time example

namespace Method_Overriding
{
    //Base class
    class Employee
    {
        public string Name { get; set; }//property
        //virtual methods
        public virtual void ShowRole()
        {
            Console.WriteLine("Role: general Employee");
        }
        public virtual double Salary()
        {
            return 40000;//default salary
        }
    }
    
    //Derived class
    class Manager : Employee
    {
        //Override the showRole method
        public override void ShowRole()
        {
            Console.WriteLine("Role: Manager");
        }
        //Override the GetSalary method
        public override double Salary()
        {
            return 80000;
        }
    }
    class Program
    {
        static void Main()
        {
            Employee emp = new Manager();
            emp.Name = "Swapna";
            Console.WriteLine($"Employee Name is: {emp.Name}");
            emp.ShowRole();
            Console.WriteLine($"salary; {emp.Salary()}");
        }
    }
}
