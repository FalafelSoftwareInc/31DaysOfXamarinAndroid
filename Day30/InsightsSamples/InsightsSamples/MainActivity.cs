using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin;

namespace InsightsSamples
{
    [Activity(Label = "InsightsSamples", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity
    {

        protected override int LayoutResource
        {
            get { return Resource.Layout.main; }
        }
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Insights.Initialize("6859cd56f8116c0964a351fa01e88931d6571088", this);

            Insights.ForceDataTransmission = true;


            // Get our button from the layout resource,
            // and attach an event to it
            var trackUserButton = FindViewById<Button>(Resource.Id.trackUserButton);

            trackUserButton.Click += TrackUserButton_Click;

            var throwErrorButton = FindViewById<Button>(Resource.Id.throwErrorButton);

            throwErrorButton.Click += ThrowErrorButton_Click;



            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);

        }

        private void ThrowErrorButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TrackUserButton_Click(object sender, EventArgs e)
        {
            var userAttributes = new Dictionary<string, string>
            {
                {"Email", "venkata@falafel.com"},
                {"UserId", "237"}
            };
            Insights.Identify("Venkata Koppaka", userAttributes);
        }
    }
}

