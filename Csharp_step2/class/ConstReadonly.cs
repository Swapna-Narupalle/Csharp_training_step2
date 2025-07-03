using System;

/// <summary>
/// const:must be assigned at declaration and cannot change.
/// readonly:only can be assigned at declaration or in constructor.
/// </summary>
class ConstReadonlyExample
{
    const int maxmarks = 100;
    //const int maxmarks;//it shows error
    readonly DateTime createddatetime;

    public ConstReadonlyExample()
    {
        //maxmarks = 200;//it shows error
        createddatetime = DateTime.Now;
    }

    public void showDetails()
    {
        Console.WriteLine("*******showDetails********");
        Console.WriteLine($"max marks is: {maxmarks}");
        Console.WriteLine($"object was created at: {createddatetime}");
    }

    static void Main()
    {
        ConstReadonlyExample constructor1 = new ConstReadonlyExample();
        System.Threading.Thread.Sleep(2000);//executes after delay
        ConstReadonlyExample constructor2 = new ConstReadonlyExample();

        constructor1.showDetails();
        constructor2.showDetails();

        //constructor1.createddatetime = DateTime.Now;//it shows error
    }
}
