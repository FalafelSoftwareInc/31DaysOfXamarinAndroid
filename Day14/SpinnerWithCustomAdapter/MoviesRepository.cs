using System;
using System.Collections.Generic;

namespace SpinnerWithCustomAdapter
{
    public static class MoviesRepository
    {
        public static List<Movie> Movies { get; private set; }

        static MoviesRepository()
        {
            Movies = new List<Movie>();
            AddMovies();
        }

        private static void AddMovies()
        {
            Movies.Add(new Movie
            {
                Title = "A New Hope",
                Director = "George Lucas",
                Episode = "IV",
                ReleaseDate = new DateTime(1977, 05, 25)
            });

            Movies.Add(new Movie
            {
                Title = "The Empire Strikes Back",
                Director = "George Lucas",
                Episode = "V",
                ReleaseDate = new DateTime(1980, 05, 17)
            });

            Movies.Add(new Movie
            {
                Title = "Return of the Jedi",
                Director = "George Lucas",
                Episode = "VI",
                ReleaseDate = new DateTime(1983, 05, 25)
            });

            Movies.Add(new Movie
            {
                Title = "The Phantom Menace",
                Director = "George Lucas",
                Episode = "I",
                ReleaseDate = new DateTime(1999, 05, 19)
            });

            Movies.Add(new Movie
            {
                Title = "Revenge of the Sith",
                Director = "George Lucas",
                Episode = "III",
                ReleaseDate = new DateTime(2005, 05, 19)
            });

            Movies.Add(new Movie
            {
                Title = "The Force Awakens",
                Director = "J.J. Abrams",
                Episode = "VII",
                ReleaseDate = new DateTime(2015, 12, 11)
            });
        }
    }
}