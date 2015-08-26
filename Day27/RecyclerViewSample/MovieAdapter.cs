using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using StarWars.Api.Repository;

namespace RecyclerViewSample
{
    public class MovieAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;

        private readonly List<Movie> movies;

        public MovieAdapter(List<Movie> movies)
        {
            this.movies = movies;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var movieViewHolder = (MovieViewHolder)holder;
            movieViewHolder.MovieNameTextView.Text = movies[position].title;
            movieViewHolder.DirectedByTextView.Text = "Directed by " + movies[position].director;
            movieViewHolder.ReleasedOnTextView.Text = "Released on " + movies[position].release_date;
            
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layout = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.MovieRow, parent, false);

            return new MovieViewHolder(layout, OnItemClick);

        }

        public override int ItemCount
        {
            get { return movies.Count; }
        }

        void OnItemClick(int position)
        {
            if (ItemClick != null)
                ItemClick(this, position);
        }
    }
}