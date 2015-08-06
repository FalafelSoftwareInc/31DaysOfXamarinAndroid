using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Uri = Android.Net.Uri;

namespace IntentSamples2
{
    [Activity(Label = "IntentSamples2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button launchFalafelComButton = FindViewById<Button>(Resource.Id.LaunchFalafelComButton);

            launchFalafelComButton.Click += launchFalafelComButton_Click;

            Button callFalafelHqButton = FindViewById<Button>(Resource.Id.CallFalafelHqButton);

            callFalafelHqButton.Click += callFalafelHqButton_Click;

            Button openFalafelHqAddressButton = FindViewById<Button>(Resource.Id.OpenFalafelHqAddressButton);

            openFalafelHqAddressButton.Click += openFalafelHqAddressButton_Click;
        }

        private void openFalafelHqAddressButton_Click(object sender, EventArgs e)
        {
            var uri = Uri.Parse("geo:37.0634800,-122.0013280");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

        private void callFalafelHqButton_Click(object sender, EventArgs e)
        {
            var uri = Uri.Parse("tel:8314620457");
            var intent = new Intent(Intent.ActionDial, uri);
            StartActivity(intent);
        }

        void launchFalafelComButton_Click(object sender, EventArgs e)
        {
            var uri = Uri.Parse("http://falafel.com");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }
    }
}

