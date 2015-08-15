using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;

namespace CardViewSample
{
    public class MovieAdapter : BaseAdapter<Movie>
    {
        private readonly Activity context;
        private readonly List<Movie> movies;

        public MovieAdapter(Activity context, List<Movie> movies)
        {
            this.context = context;
            this.movies = movies;
        }

        public override Movie this[int position]
        {
            get
            {
                return movies[position];
            }
        }

        public override int Count
        {
            get
            {
                return movies.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.MovieRow, parent, false);
            }

            var titleTextView = view.FindViewById<TextView>(Resource.Id.cardViewText);
            var imageView = view.FindViewById<ImageView>(Resource.Id.imageView);

            titleTextView.Text = movies[position].Title;
            imageView.SetImageResource(Resource.Drawable.starwarslogo);

            return view;
        }
    }
}