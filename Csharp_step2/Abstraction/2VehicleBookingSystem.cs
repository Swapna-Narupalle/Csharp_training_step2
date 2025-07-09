using System;
using System.Collections.Generic;


namespace Vehicle_OnlineBooking_System
{
    abstract class Vehicle
    {
        // Abstract class
        public string FuelType { get; set; }
        public int Capacity { get; set; }
        public abstract void Start();
        public abstract string Stop();
        public abstract string Engine();
        public string ShowDetails()
        {
           return $"FuelType: {FuelType} and Capacity: {Capacity}";
           
        }
    }
    // Derived class - Car
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key ignition.");
        }
        public override string Stop()
        {
            return $"Car has stopped.";
        }
        public override string Engine()
        {
            return $"Car engine is a 4-cylinder petrol engine.";
        }
    }
    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key ignition.");
        }
        public override string Stop()
        {
            return $"Car has stopped.";
        }
        public override string Engine()
        {
            return $"Car engine is a 4-cylinder petrol engine.";
        }
    }
    class Program
    {
        static void Main()
        {
            //List<Vehicle> bookings = new List<Vehicle>();

            Console.WriteLine("****Welcome to Vehicle online Booking system*****");
            Console.WriteLine("Select Vehicle Type:");
            Console.WriteLine("1.Car, 2.Bike");
            Console.WriteLine("Enter your choice(1 or 2)");
            string Choice = Console.ReadLine();
            Vehicle selectedVehicle = null;
            switch (Choice)
            {
                case "1":
                    selectedVehicle = new Car();
                    break;
                case "2":
                    selectedVehicle = new Bike();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            //Input fuel type and capacity
            Console.WriteLine("enter Fuel Type(Petrol/Diesel/electric:)");
            selectedVehicle.FuelType = Console.ReadLine();

            Console.Write("Enter Capacity (number of passengers): ");
            selectedVehicle.Capacity = int.Parse(Console.ReadLine());

            //bookings.Add(selectedVehicle);

            //show booking summary
            Console.WriteLine("\n---Booking Confirmed----");
            Console.WriteLine($"Booking Time: {DateTime.Now}");
            selectedVehicle.ShowDetails();
            selectedVehicle.Start();
            selectedVehicle.Stop();
            selectedVehicle.Engine();
            Console.WriteLine("\nThank you for using our Vehicle Booking System!");


        }
    }
}
