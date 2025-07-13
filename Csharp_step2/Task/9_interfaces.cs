using System;

//9. Write the Program on Single class with different interfaces
namespace interfaces_2
{
    /// <summary>
    /// Interface provides rules and it would't implemenet
    /// </summary>
    interface Imovies
    {
        string GetMovieName(string movie);
        void MovieDirector();
        string GetMovieActor(string actor);
        void MovieActress(string actress);

    }

    interface ImovieBudjet
    {
        string GetMovieBudget();
    }

    interface ImovieCollection
    {
        string GetmovieCollection();
    }

    interface ImovieProfit
    {
        void movieProfit();
    }

    class RRR : Imovies, ImovieBudjet, ImovieCollection, ImovieProfit
    {
        private double budjet = 500;//in crores
        private double collection = 1500;//in crores

        public string GetMovieActor(string actor)
        {
            return $"actor Name: {actor}";
        }

        public void MovieActress(string actress)
        {
            Console.WriteLine($"actress name: {actress}");
        }

        public void MovieDirector()
        {
            string director = "S.S.Rajamouli";
            Console.WriteLine($"Director name: {director}");
        }

        public string GetMovieName(string movie)
        {
            return $"**********{movie}************";

        }

        public string GetMovieBudget()
        {

            return $"Movie budjet: {budjet}cr";
        }

        public string GetmovieCollection()
        {

            return $"Movie collection: {collection}cr";
        }

        public void movieProfit()
        {
            double profit = collection - budjet;
            Console.WriteLine($"Profit: {profit}cr");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("-------RRR Details---------");
            Imovies rrr1 = new RRR();
            Console.WriteLine(rrr1.GetMovieName("RRR"));
            rrr1.MovieDirector();
            Console.WriteLine(rrr1.GetMovieActor("NTR"));
            rrr1.MovieActress("Alia bat");

            ImovieBudjet rrr2 = new RRR();
            Console.WriteLine(rrr2.GetMovieBudget());

            ImovieCollection rrr3 = new RRR();
            Console.WriteLine(rrr3.GetmovieCollection());

            ImovieProfit rrr4 = new RRR();
            rrr4.movieProfit();
        }
    }
}
