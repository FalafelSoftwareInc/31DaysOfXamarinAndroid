using Android.App;
using Android.OS;
using Android.Widget;

namespace AdapterDemo1
{
    [Activity(Label = "AdapterDemo1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var moviesListView = FindViewById<ListView>(Resource.Id.moviesListView);

            var moviesAdpater = new ArrayAdapter<Movie>(this, Android.Resource.Layout.SimpleListItem1, MoviesRepository.Movies);
            
            moviesListView.Adapter = moviesAdpater;

            moviesListView.ItemClick += moviesListView_ItemClick;
        }

        void moviesListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, MoviesRepository.Movies[e.Position].ToString(), ToastLength.Long).Show();

        }
    }
}

