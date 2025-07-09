using System;


namespace VehicleConfigurationSystem
{
    //abstract class
    // Rule +  methodImplemention
    abstract class Vehicle
    {
        public string FuelType { get; set; }
        public int Capacity { get; set; }
        public abstract void Start();
        public abstract void Stop();
        public abstract void Engine();
        //Concrete methods
        public void ShowDetails()
        {
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Capacity: {Capacity} passengers");
        }
    }
    //Derive class or child class

    class Car: Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key ignition");
        }
        public override void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
        public override void Engine()
        {
            Console.WriteLine("Car engine is a 2-cylinder petrol engine.");
        }
        public void CarPurchaseDateandTime()
        {
            Console.WriteLine("12-06-2024:12:35:00");
        }
    }

    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting with a kick-start");
        }
        public override void Engine()
        {
            Console.WriteLine("Bike engine is a 2-stroke petrol engine.");
        }
        public override void Stop()
        {
            Console.WriteLine("Bike has stopped");
        }

    }
    // 1. For Abastract class you cnnot create instance
    // 2. But Abstract class we can refer the to the child or dervied classs
    class Program
    {
        public static void Main()
        {
            Vehicle car = new Car();
            car.FuelType = "Petrol";
            car.Capacity = 4;

            car.ShowDetails(); ; // Focus on essentials (high-level details) //concreate method
            car.Start();// abstart method.
            car.Stop();// abstart method.
            car.Engine();// abstart method.

            Vehicle bike = new Bike()
            {
                FuelType = "petrol",
                Capacity = 2
            };
            bike.ShowDetails();// Focus on essentials (high-level details) //concreate method
            bike.Start();// abstart method.
            bike.Stop();// abstart method.
            bike.Engine();// abstart method.


        }
    }
}
