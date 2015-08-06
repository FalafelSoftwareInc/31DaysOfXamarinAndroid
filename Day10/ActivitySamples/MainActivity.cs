using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace ActivitySamples
{
    [Activity(Label = "ActivitySamples", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += button_Click;
        }

        void button_Click(object sender, EventArgs e)
        {
            var messageEditText = this.FindViewById<EditText>(Resource.Id.MessageEditText);

            var intent = new Intent(this, typeof (DetailsActivity));
            
            intent.PutExtra("TitleToShow", messageEditText.Text);

            StartActivity(intent);
        }
        
        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }

        protected override void OnStop()
        {
            base.OnStop();
        }

        protected override void OnRestart()
        {
            base.OnRestart();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }

    }
}

