using Android.App;
using Android.OS;
using Android.Widget;

namespace FunWithControls
{
    [Activity(Label = "FunWithControls", MainLauncher = false, Icon = "@drawable/icon")]
    public class CheckBoxSampleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.CheckBoxSample);

            var checkBox = FindViewById<CheckBox>(Resource.Id.checkBox);

            checkBox.CheckedChange += checkBox_CheckedChange;

            Toast.MakeText(this, checkBox.Checked.ToString(), ToastLength.Long).Show();
        }

        void checkBox_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            Toast.MakeText(this, e.IsChecked.ToString(), ToastLength.Long).Show();
        }

    }
}

