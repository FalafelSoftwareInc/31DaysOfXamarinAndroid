using Android.App;
using Android.OS;
using Android.Widget;

namespace FunWithControls
{
    [Activity(Label = "FunWithControls", MainLauncher = false, Icon = "@drawable/icon")]
    public class ToggleSampleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ToggleSample);

            var toggleButton = FindViewById<ToggleButton>(Resource.Id.myToggleButton);

            Toast.MakeText(this, toggleButton.Checked.ToString(), ToastLength.Long).Show();

            toggleButton.CheckedChange += toggleButton_CheckedChange;
        }

        void toggleButton_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            Toast.MakeText(this, e.IsChecked.ToString(), ToastLength.Long).Show();
        }

    }
}

