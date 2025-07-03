using System;

/// <summary>
/// Constructors: constructor is a special method that can be used to initialize the objects
/// it is called when the instance of the class is created
/// </summary>
class MovieDetailsConstructors
{
    //fields
    string moviename = "RRR";
    string moviedirector = "Rajamouli";
    string movieactor = "NTR";
    string movierileasedate = "05-06-2022";
    DateTime dateTime = new DateTime();


    public MovieDetailsConstructors()
    {
        Console.WriteLine("******movieDetails1**********");

        Console.WriteLine($"moviename is: {moviename}");//RRR

        Console.WriteLine("******updatedmovieDetails1**********");
        this.moviename = "Devara";
        this.moviedirector = "Koratala siva";
        this.movieactor = "Jr NTR";
        this.movierileasedate = "08-10-2024";

        Console.WriteLine($"movie name is: {moviename}");//Devara
    }


    public MovieDetailsConstructors(string movieactor2)
    {
        Console.WriteLine("******movieDetails2**********");

        Console.WriteLine($"Second actor of {moviename} is: {movieactor2}");//RRR, Ram charan
    }


    public MovieDetailsConstructors(string moviename, string moviedirector, string movieactor, string moviereleasedate)
    {
        Console.WriteLine("******movieDetails3**********");

        this.moviename = moviename;//Kalki
        this.moviedirector = moviedirector;//Nag aswin
        this.movieactor = movieactor;//prabhas
        this.movierileasedate = moviereleasedate;//03-04-2024

        Console.WriteLine($"Movie: {moviename}");//Kalki
        Console.WriteLine($"Director: {moviedirector}");//Nag aswin
        Console.WriteLine($"Actor: {movieactor}");//prabhas
        Console.WriteLine($"ReleaseDate: {moviereleasedate}");//03-04-2024
    }

    static void Main()
    {
        MovieDetailsConstructors movieDetails1 = new MovieDetailsConstructors();

        MovieDetailsConstructors movieDetails2 = new MovieDetailsConstructors("Ram charan");

        MovieDetailsConstructors movieDetails3 = new MovieDetailsConstructors("Kalki", "Nag aswin", "Prabhas", "03-04-2024");
    }
}
