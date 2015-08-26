using System.Collections.Generic;

// ReSharper disable InconsistentNaming - Naming for remote api

namespace StarWars.Api.Repository
{
    public class Movie
    {
        public string title { get; set; }
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer { get; set; }
        public string release_date { get; set; }
        public List<string> characters { get; set; }
        public List<string> planets { get; set; }
        public List<string> starships { get; set; }
        public List<object> vehicles { get; set; }
        public List<string> species { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
        public string url { get; set; }

    }

    public class Films
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<Movie> results { get; set; }
    }
}