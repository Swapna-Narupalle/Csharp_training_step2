using System;
using System.Runtime.CompilerServices;
/// <summary>
/// for non static class we can create number of instances
/// for non static class we have to create the instance
/// for static class no need to create the instance
/// </summary>
class MovieDetails
{
    //fields: fields are variables that belongs to the class.
    //they represent the data that an object of the class can hold.
    string movieName = "RRR";
    string movieDirector = "Rajamouli";
    string movieActor = "NTR";
    string movieReleasedate = "22-06-2022";

    void ShowaboutDevaraMovie(string movieName, string movieDirector)
    {
        Console.WriteLine($"{this.movieName} is directed by {this.movieDirector}");//Devara,Koratala siva
    }

    static string ShowaboutKalkiMovie(string movieName, string movieReleasedate)
    {
        return $"{movieName} was reliesed in {movieReleasedate}";
    }

    static void ShowMoviemessages(MovieDetails movie)
    {
        Console.WriteLine($"moviename:{movie.movieName}, movieActor: {movie.movieActor}");
    }

    static void ShowMoviemessages_2(MovieDetails movie2)
    {
        Console.WriteLine($"moviename:{movie2.movieName}, movieActor: {movie2.movieActor}");
    }


    static void Main()
    {
        MovieDetails movieDetails = new MovieDetails();
        movieDetails.movieName = "Devara";
        movieDetails.movieDirector = "Koratala siva";
        movieDetails.movieActor = "Jr.NTR";
        movieDetails.movieReleasedate = "02-10-2024";
        //string actorName = movieDetails.movieActor;
        //Console.WriteLine(actorName);

        Console.WriteLine($"print the instance of the class: {movieDetails}");//MovieDetails
        Console.WriteLine($"movieName: {movieDetails.movieName}");//Devara
        Console.WriteLine($"directorName: {movieDetails.movieDirector}");//Koratala siva
        Console.WriteLine($"actorName: {movieDetails.movieActor}");//Jr.NTR
        Console.WriteLine($"rilieseDate: {movieDetails.movieReleasedate}");//02-10-2024


        ShowMoviemessages(movieDetails);


        MovieDetails movie4 = new MovieDetails()
        {
            movieName = "salar",
            movieDirector = "Prasanth neel",
            movieActor = "Prabash",
            movieReleasedate = "02-05-2024"
        };
        ShowMoviemessages_2(movie4);


        movieDetails.ShowaboutDevaraMovie(movieDetails.movieName, movieDetails.movieDirector);


        string aboutkalkiMovie = ShowaboutKalkiMovie("Kalki", "06-05-2024");
        Console.WriteLine(aboutkalkiMovie);
    }
}
