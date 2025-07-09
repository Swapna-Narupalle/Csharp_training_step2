using System;


namespace CompileTime_Polymorphism_System
{
    //Method overloading
    //Input types are different
   public class SalaryCalculator
    {
        public double CalculateSalary(double monthlySalary)
        {
            return monthlySalary;
        }
        public double CalculateSalary(int monthlySalary)
        {
            return monthlySalary;
        }
        public double CalculateSalary(int hoursWorked, int hoursRate)
        {
            return hoursWorked * hoursRate;
        }
        public double CalculateSalary(double salesAmount, double commissionRate)
        {
            return salesAmount * commissionRate;
        }
        public double CalculateSalary(int hoursWorked, int hoursRate, double bonus)
        {
            return (hoursWorked * hoursRate)+bonus;
        }
    }
   class program
    {
        static void Main()
        {
            SalaryCalculator salaryCalculator = new SalaryCalculator();
            double salary1 = salaryCalculator.CalculateSalary(30000.98);
            double salary2 = salaryCalculator.CalculateSalary(20000);
            double salary3 = salaryCalculator.CalculateSalary(10,200);
            double salary4 = salaryCalculator.CalculateSalary(4000, 0.10);
            double salary5 = salaryCalculator.CalculateSalary(4, 2000, 200.67);


            Console.WriteLine($"salary1: {salary1}");
            Console.WriteLine($"salary2: {salary2}");
            Console.WriteLine($"salary3: {salary3}");
            Console.WriteLine($"salary4: {salary4}");
            Console.WriteLine($"salary5: {salary5}");
        }
    }
}
