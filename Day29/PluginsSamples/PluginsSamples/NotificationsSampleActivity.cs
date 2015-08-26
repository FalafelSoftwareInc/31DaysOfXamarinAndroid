using Android.App;
using Android.OS;
using Android.Widget;
using EdSnider.Plugins;

namespace PluginsSamples
{
    [Activity(Label = "NotificationsSampleActivity", MainLauncher = false, Icon = "@drawable/icon")]
    public class NotificationsSampleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.notificationssamplelayout);

            var showNotificationButton = FindViewById<Button>(Resource.Id.showNotificationButton);

            showNotificationButton.Click += ShowNotificationButton_Click;

        }

        private void ShowNotificationButton_Click(object sender, System.EventArgs e)
        {
            Notifier.Current.Show("Local Notification", "This is a simple local notification");
        }
    }
}