using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;

namespace AdapterDemo2
{
    public class MovieAdapter : BaseAdapter<Movie>, ISectionIndexer
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

            var titleTextView = view.FindViewById<TextView>(Resource.Id.titleTextView);
            var directedByTextView = view.FindViewById<TextView>(Resource.Id.directedByTextView);
            var releasedDateTextView = view.FindViewById<TextView>(Resource.Id.releasedDateTextView);

            titleTextView.Text = movies[position].Title;
            directedByTextView.Text = "Directed by: " + movies[position].Director;
            releasedDateTextView.Text = "Released on: " + movies[position].ReleaseDate.ToShortDateString();

            return view;
        }

        Java.Lang.Object[] sectionHeaders = SectionIndexerBuilder.BuildSectionHeaders(MoviesRepository.Movies);
        Dictionary<int, int> positionForSectionMap = SectionIndexerBuilder.BuildPositionForSectionMap(MoviesRepository.Movies);
        Dictionary<int, int> sectionForPositionMap = SectionIndexerBuilder.BuildSectionForPositionMap(MoviesRepository.Movies);

        public Java.Lang.Object[] GetSections()
        {
            return sectionHeaders;
        }

        public int GetPositionForSection(int section)
        {
            return positionForSectionMap[section];
        }

        public int GetSectionForPosition(int position)
        {
            return sectionForPositionMap[position];
        }
    }
}