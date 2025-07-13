using StudentNamespace;
using System;

//14. Example on Method Overloading – Real time example 
///<summary>
///Method Overloading means creating multiple methods with the same name in the same class but with different parameters (type or number
///</summary>

namespace Method_Overloading
{
    class BillPayment
    {
        //Method1:Pay by Cash
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} in cash.");
        }
        // Method 2: Pay by card
        public void MakePayment(string cardNumber, double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using card: {cardNumber}");
        }
        // Method 3: Pay by UPI
        public void MakePayment(string upiId, double amount, string remarks)
        {
            Console.WriteLine($"Paid ₹{amount} via UPI ID: {upiId}. Remarks: {remarks}");
        }
    }
    class program
    {
        static void Main()
        {
            BillPayment payment = new BillPayment();
            payment.MakePayment(2000);
            payment.MakePayment("1234RRT", 3000);
            payment.MakePayment("Swapna@9010", 90000, "Hostel fee");
        }
    }
}
