using Android.App;
using Android.OS;
using Android.Widget;

namespace SpinnerWithCustomAdapter
{
    [Activity(Label = "SpinnerWithCustomAdapter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var moviesSpinner = FindViewById<Spinner>(Resource.Id.moviesSpinner);

            moviesSpinner.Adapter = new MoviesAdapter(this, MoviesRepository.Movies);

            moviesSpinner.ItemSelected += moviesSpinner_ItemSelected;
        }

        void moviesSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;

            string toast = string.Format(spinner.GetItemAtPosition(e.Position).ToString());
            Toast.MakeText(this, toast, ToastLength.Long).Show();

        }
    }
}

