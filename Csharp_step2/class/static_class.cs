using System;

/// <summary>
/// all members should be static only
/// instance when you want to call the member
/// </summary>
static class FoodOrderDetails
{

    static string restaurantname;
    static string customername = "Rushi";
    static string itemname;
    static double price;

    static string CustomerName { get; set; }

    //only one static constructor should be allowed
    static FoodOrderDetails()
    {
        Console.WriteLine("Enter restaurent name:");
        FoodOrderDetails.restaurantname = Console.ReadLine();
        Console.WriteLine($"Welcome to {restaurantname} restaurent");
    }

    static string Custemername()
    {
        Console.WriteLine("enter custemer name:");
        FoodOrderDetails.CustomerName = Console.ReadLine();
        return CustomerName;
    }

    static double FooditemDetails()
    {
        Console.WriteLine("select the item: (gobi, chicken biryani, eggrice");
        FoodOrderDetails.itemname = Console.ReadLine().ToLower();
        switch (itemname)
        {
            case "gobi":
                return 80.45;
                break;
            case "chicken biryani":
                return 250.67;
                break;
            case "eggrice":
                return 120.34;
                break;
            default:
                Console.WriteLine("Invalid input, pls select the item from the menu");
                return 0.0;
        }

    }
   

    static void Main()
    {
        string customer = Custemername();
        Console.WriteLine($"custemer name is: {customer}");

        double Price = FooditemDetails();
        if (Price > 0)
        {
            Console.WriteLine($"Foodorder Details:\n RestaurantName: {restaurantname}\n CustomerName: {customer}\n ItemName: {itemname}\n itemPrice: {Price}");
            Console.WriteLine($"Thank You for visiting {restaurantname} restaurant");
        }
        else
        {
            Console.WriteLine("Order could not be completed, due to the invalid item selection");
        }
        //Console.WriteLine($"Thank You for visiting {restaurantname} restaurant");
       
    }
}
