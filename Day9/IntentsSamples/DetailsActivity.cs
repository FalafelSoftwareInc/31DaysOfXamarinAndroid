using Android.App;
using Android.OS;

namespace IntentsSamples
{
    [Activity(Label = "DetailsActivity")]
    public class DetailsActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Details);
        }
    }
}