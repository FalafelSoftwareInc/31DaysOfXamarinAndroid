using System;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Widget;

namespace ToastsAndSnackbarsSample
{
    [Activity(Label = "ToastsAndSnackbarsSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity
    {

        protected override int LayoutResource
        {
            get { return Resource.Layout.main; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Get our button from the layout resource,
            // and attach an event to it
            var showToastButton = FindViewById<Button>(Resource.Id.showToastButton);

            showToastButton.Click += ShowToastButton_Click;

            var snackbarButton = FindViewById<Button>(Resource.Id.showSnackbarButton);

            snackbarButton.Click += SnackbarButton_Click;

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);
        }

        private void SnackbarButton_Click(object sender, EventArgs e)
        {
            var linearLayout = FindViewById<LinearLayout>(Resource.Id.main_content);
            Snackbar.Make(linearLayout, "This is a simple snackbar.", Snackbar.LengthLong)
                    .SetAction("OK", action => { })
                    .Show();
        }

        private void ShowToastButton_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "This is a simple toast", ToastLength.Short).Show();
        }
    }
}

