using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PluginsSamples
{
    [Activity(Label = "SettingsActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class SettingsActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.SettingsSampleLayout);

            var setSettingButton = FindViewById<Button>(Resource.Id.setSettingButton);

            setSettingButton.Click += SetSettingButton_Click;

            var retrieveSettingButton = FindViewById<Button>(Resource.Id.retrieveSettingButton);
            retrieveSettingButton.Click += RetrieveSettingButton_Click;
        }

        private void RetrieveSettingButton_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Setting value is " + ApplicationSettings.LoginNameSetting, ToastLength.Long).Show();
        }

        private void SetSettingButton_Click(object sender, EventArgs e)
        {
            ApplicationSettings.LoginNameSetting = "Venkata@falafel.com";
        }
    }
}