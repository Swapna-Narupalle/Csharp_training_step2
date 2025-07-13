using System;

//12.Prepare the abstract class and add abstract members and non-abstract members 

//abstract class: It contain both abstract and concrete(non-abstract) members.
namespace Area_Calculation
{
    abstract class Shape
    {
        // Abstract method (must be overridden in child class)
        public abstract double CalculateArea();

        // Abstract property (must be overridden in child class)
        public abstract string ShapeName { get; set; }

        // Concrete method (has body)
        public void showInfo()
        {
            Console.WriteLine($"This is a {ShapeName}");
        }

        // Concrete method (has body)
        public void ShowFormula()
        {
            Console.WriteLine("formula depends on the shape type");
        }
    }
    //derived class Rectangle
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override string ShapeName { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            ShapeName = "Rectangle";
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    //derived class Circle
    class Circle : Shape
    {
        public const double pi = 3.14;
        public double Radius { get; set; }

        public override string ShapeName { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            ShapeName = "Circle";
        }

        public override double CalculateArea()
        {

            return  pi* Radius * Radius;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-------------Rectangle---------------");
            Shape rect = new Rectangle(6, 3);
            rect.showInfo();
            rect.ShowFormula();
            Console.WriteLine($"Area of rectangle is: {rect.CalculateArea()}");

            Console.WriteLine("-------------Circle---------------");
            Shape circle = new Circle(5.5);
            circle.showInfo();
            circle.ShowFormula();
            Console.WriteLine($"Area of Circle is: {circle.CalculateArea()}");
        }
    }
}
