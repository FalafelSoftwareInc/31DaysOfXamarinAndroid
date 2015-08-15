using Android.App;
using Android.Widget;
using Android.OS;

namespace CardViewSample
{
    [Activity(Label = "CardViewSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity
    {

        protected override int LayoutResource
        {
            get { return Resource.Layout.main; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var moviesListView = FindViewById<ListView>(Resource.Id.moviesListView);

            moviesListView.ItemClick += moviesListView_ItemClick;

            var moviesAdapter = new MovieAdapter(this, MoviesRepository.Movies);

            moviesListView.Adapter = moviesAdapter;

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);
        }

        void moviesListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, MoviesRepository.Movies[e.Position].ToString(), ToastLength.Long).Show();
        }
    }
}

