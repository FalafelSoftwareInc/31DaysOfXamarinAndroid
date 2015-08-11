using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;

namespace SpinnerWithCustomAdapter
{
    public class MoviesAdapter : BaseAdapter<Movie>
    {
        private readonly Activity context;
        private readonly List<Movie> movies;

        public MoviesAdapter(Activity context, List<Movie> movies)
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
            View view = convertView; 
            if (view == null) // otherwise create a new one
            {
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            }
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = movies[position].ToString();
            return view;

        }
    }
}