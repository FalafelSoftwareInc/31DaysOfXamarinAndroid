using Android.App;
using Android.OS;
using Android.Widget;

namespace FunWithMediaControls
{
    [Activity(Label = "FunWithMediaControls", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Gallery gallery = FindViewById<Gallery>(Resource.Id.gallery);

            gallery.Adapter = new CuteCatsAdapter(this);

            gallery.ItemClick += Gallery_ItemClick;

        }

        private void Gallery_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, e.Position.ToString(), ToastLength.Short).Show();
        }
    }
}


