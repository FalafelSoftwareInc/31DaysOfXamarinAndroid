using System;

namespace CardViewSample
{
    public class Movie
    {
        public string Title { get; set; }
        public string Episode { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }

        public override string ToString()
        {
            return "Episode " + Episode + " " + Title + " by " + Director;
        }
    }
}