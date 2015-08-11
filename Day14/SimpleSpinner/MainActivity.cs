using Android.App;
using Android.OS;
using Android.Widget;

namespace SimpleSpinner
{
    [Activity(Label = "SimpleSpinner", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var moviesSpinner = FindViewById<Spinner>(Resource.Id.moviesSpinner);

            var moviesAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.movies_array, Android.Resource.Layout.SimpleSpinnerItem);

            moviesAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

            moviesSpinner.Adapter = moviesAdapter;
        }
    }
}

