using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.Widget;
using Android.Widget;

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
        private RecyclerView.LayoutManager layoutManager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            
            layoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);

            recyclerView.SetLayoutManager(layoutManager);

            var moviesAdapter = new MovieAdapter(MoviesRepository.Movies);

            recyclerView.SetAdapter(moviesAdapter);

            moviesAdapter.ItemClick += MoviesAdapter_ItemClick;

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);
        }

        private void MoviesAdapter_ItemClick(object sender, int e)
        {
            var linearLayout = this.FindViewById<LinearLayout>(Resource.Id.main_content);

            Snackbar.Make(linearLayout, MoviesRepository.Movies[e].ToString(), Snackbar.LengthLong).Show(); // Don’t forget to show!

        }
    }
}

