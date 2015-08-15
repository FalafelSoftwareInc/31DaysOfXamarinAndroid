using Android.App;
using Android.OS;
using Android.Widget;

namespace AdapterDemo2
{
    [Activity(Label = "AdapterDemo2", 
        MainLauncher = true, 
        Theme = "@android:style/Theme.Holo.Light",
        Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var moviesListView = FindViewById<ListView>(Resource.Id.moviesListView);

            moviesListView.FastScrollEnabled = true;

            moviesListView.ItemClick += moviesListView_ItemClick;

            var moviesAdapter = new MovieAdapter(this, MoviesRepository.Movies);

            moviesListView.Adapter = moviesAdapter;
        }

        void moviesListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, MoviesRepository.Movies[e.Position].ToString(), ToastLength.Long).Show();

        }
    }
}

