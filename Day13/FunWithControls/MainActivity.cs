using Android.App;
using Android.OS;
using Android.Widget;

namespace FunWithControls
{
    [Activity(Label = "FunWithControls", MainLauncher = false, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var switchView = FindViewById<Switch>(Resource.Id.switch1);

            switchView.CheckedChange += switchView_CheckedChange;

            Toast.MakeText(this, switchView.Checked.ToString(), ToastLength.Long).Show();
        }

        void switchView_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            Toast.MakeText(this, e.IsChecked.ToString(), ToastLength.Long).Show();
        }
    }
}

