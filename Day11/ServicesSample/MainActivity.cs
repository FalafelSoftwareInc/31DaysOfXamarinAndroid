using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace ServicesSample
{
    [Activity(Label = "ServicesSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button startServiceButton = FindViewById<Button>(Resource.Id.StartServiceButton);

            startServiceButton.Click += startServiceButton_Click;

            Button stopServiceButton = FindViewById<Button>(Resource.Id.StopServiceButton);

            stopServiceButton.Click += stopServiceButton_Click;
        }

        private void stopServiceButton_Click(object sender, EventArgs e)
        {
            StopService(new Intent(this, typeof (DemoService)));
        }

        void startServiceButton_Click(object sender, EventArgs e)
        {
            StartService(new Intent(this, typeof (DemoService)));
        }
    }
}

