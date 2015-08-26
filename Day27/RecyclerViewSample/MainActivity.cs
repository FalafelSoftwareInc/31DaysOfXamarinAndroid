using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Widget;
using StarWars.Api.Repository;

namespace RecyclerViewSample
{
    [Activity(Label = "RecyclerViewSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity
    {

        protected override int LayoutResource
        {
            get { return Resource.Layout.main; }
        }

        private RecyclerView recyclerView;
        private ProgressBar activityIndicator;
        private RecyclerView.LayoutManager layoutManager;

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            activityIndicator = FindViewById<ProgressBar>(Resource.Id.activityIndicator);

            activityIndicator.Visibility = Android.Views.ViewStates.Visible;

            layoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);

            recyclerView.SetLayoutManager(layoutManager);

            var repository = new MoviesRepository();

            var films = await repository.GetAllFilms();

            var moviesAdapter = new MovieAdapter(films.results);

            recyclerView.SetAdapter(moviesAdapter);

            activityIndicator.Visibility = Android.Views.ViewStates.Gone;

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);
        }

       
    }
}

