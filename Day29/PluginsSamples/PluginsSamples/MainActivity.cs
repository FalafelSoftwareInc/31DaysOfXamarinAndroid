using System;
using System.Linq;
using Android.App;
using Android.Widget;
using Android.OS;
using Connectivity.Plugin;
using Connectivity.Plugin.Abstractions;

namespace PluginsSamples
{
    [Activity(Label = "PluginsSamples", MainLauncher = false, Icon = "@drawable/icon")]
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
            var getConnectivityStatusButton = FindViewById<Button>(Resource.Id.getConnectivityStatusButton);

            getConnectivityStatusButton.Click += GetConnectivityStatusButton_Click;


            var isConnectedToWifiButton = FindViewById<Button>(Resource.Id.isConnectedToWifiButton);

            isConnectedToWifiButton.Click += IsConnectedToWifiButton_Click;

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);

        }

        private void IsConnectedToWifiButton_Click(object sender, EventArgs e)
        {
            var connectionTypes = CrossConnectivity.Current.ConnectionTypes;
            bool isWifi = connectionTypes.Any(connectionType => connectionType == ConnectionType.WiFi);

            if (isWifi)
            {
                Toast.MakeText(this, "You are currently connected to a WIFI network", ToastLength.Long).Show();
            }
            else
            {
                Toast.MakeText(this, "You are currently NOT connected to a WIFI network", ToastLength.Long).Show();
            }

        }

        private void GetConnectivityStatusButton_Click(object sender, EventArgs e)
        {
            var isConnected = CrossConnectivity.Current.IsConnected;

            if (isConnected)
            {
                Toast.MakeText(this, "You are currently connected to internet", ToastLength.Long).Show();
            }
            else
            {
                Toast.MakeText(this, "You are currently NOT connected to internet", ToastLength.Long).Show();
            }

        }
    }
}

