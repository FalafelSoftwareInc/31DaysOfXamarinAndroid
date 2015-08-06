using Android.App;
using Android.OS;
using Android.Widget;

namespace ActivitySamples
{
    [Activity(Label = "DetailsActivity")]
    public class DetailsActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.Details);

            var titleToShow = Intent.GetStringExtra("TitleToShow");

            var titleTextView = this.FindViewById<TextView>(Resource.Id.TitleTextView);

            if (string.IsNullOrWhiteSpace(titleToShow))
            {
                titleToShow = "Didn't receive anything from First screen";
            }

            titleTextView.Text = titleToShow;
        }
    }
}