using System;

//8. Write the example of interface implementation by using class

namespace interfaces
{
    /// <summary>
    /// Interface provides rules and it would't implemenet
    /// </summary>
    interface Imovies
    {
        string GetMovieName(string movie);
        void showDirectorName();
        string GetActorName(string actor);
        
    }
    class RRR : Imovies
    {
        public string GetActorName(string actor)
        {
            return $"actor: {actor}";
        }

        public string GetMovieName(string movie)
        {
            return $"Movie: {movie}";
        }

        public void showDirectorName()
        {
            string director = "Rajamouli";
            Console.WriteLine($"Director: {director}");
        }
    }
    class Bahubali : Imovies
    {
        public string GetActorName(string actor)
        {
            return $"actor: {actor}";
        }

        public string GetMovieName(string movie)
        {
            return $"Movie: {movie}";
        }

        public void showDirectorName()
        {
            string director = "Rajamouli";
            Console.WriteLine($"Director: {director}");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("------------RRR--------------");
            Imovies rrr = new RRR();
            Console.WriteLine(rrr.GetMovieName("RRR"));
            rrr.showDirectorName();
            Console.WriteLine(rrr.GetActorName("NTR"));

            Console.WriteLine("------------Bahubali--------------");
            Imovies bahubali = new Bahubali();
            Console.WriteLine(bahubali.GetMovieName("Bahubali"));
            bahubali.showDirectorName();
            Console.WriteLine(bahubali.GetActorName("Prabhas"));
        }
    }
}
