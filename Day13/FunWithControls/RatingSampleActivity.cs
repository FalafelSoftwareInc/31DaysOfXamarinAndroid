using System.Globalization;
using Android.App;
using Android.OS;
using Android.Widget;

namespace FunWithControls
{
    [Activity(Label = "FunWithControls", MainLauncher = true, Icon = "@drawable/icon")]
    public class RatingSampleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.RatingSample);

            var button = FindViewById<Button>(Resource.Id.getRatingButton);

            button.Click += button_Click;
        }

        void button_Click(object sender, System.EventArgs e)
        {
            var ratingBar = FindViewById<RatingBar>(Resource.Id.myRatingBar);
            Toast.MakeText(this, ratingBar.Rating.ToString(CultureInfo.InvariantCulture), ToastLength.Long).Show();

        }
    }
}

