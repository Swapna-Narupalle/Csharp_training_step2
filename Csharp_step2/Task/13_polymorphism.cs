using System;

//13. Prepare the Base class with virtual methods and derived class with override methods

namespace Polymorphism
{
    // Base class
    class Employee
    {
        public string Name { get; set; }
        //virtual Methods(can be overriden)
        public virtual void ShowRole()
        {
            Console.WriteLine("Role: General Employee");
        }
        public virtual double Salary()
        {
            return 30000;//default salary
        }
    }

    //Derived class
    class Manager : Employee
    {
        //override the showrole and salary methods
        public override void ShowRole()
        {
            Console.WriteLine("Role:Manager");
        }
        public override double Salary()
        {
            return 70000;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Manager();
            emp.Name = "Sreeja";
            Console.WriteLine($"Employee name: {emp.Name}");
            emp.ShowRole();
            Console.WriteLine($"employee salary: {emp.Salary()}");
        }
    }
}
