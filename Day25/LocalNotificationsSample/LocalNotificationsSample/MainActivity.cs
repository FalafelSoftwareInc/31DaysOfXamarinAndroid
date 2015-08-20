using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace LocalNotificationsSample
{
    [Activity(Label = "LocalNotificationsSample", MainLauncher = true, Icon = "@drawable/icon")]
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
            var simpleNotificationButton = FindViewById<Button>(Resource.Id.simpleNotificationButton);

            simpleNotificationButton.Click += SimpleNotificationButton_Click;

            var advancedNotificationButton = FindViewById<Button>(Resource.Id.advancedNotificationButton);

            advancedNotificationButton.Click += AdvancedNotificationButton_Click;

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);

        }

        private void AdvancedNotificationButton_Click(object sender, EventArgs e)
        {
            Notification.Builder builder = new Notification.Builder(this)
                                            .SetContentTitle("Expanded Layout Notification")
                                            .SetContentText("Learn more about Star Wars")
                                            .SetSmallIcon(Resource.Drawable.notifcation_icon);

            Notification.BigTextStyle textStyle = new Notification.BigTextStyle();

            string longTextMessage = "Lucas ipsum dolor sit amet darth alderaan droid kessel organa jango leia amidala leia aayla. Darth lars sidious grievous. Mara mara wampa skywalker dantooine mon. Watto sith calamari lobot organa qui-gonn alderaan. Boba watto yoda sidious skywalker skywalker ahsoka skywalker.";

            textStyle.BigText(longTextMessage);

            textStyle.SetSummaryText("The Star Wars Ipsum");

            builder.SetStyle(textStyle);

            Notification notification = builder.Build();

            NotificationManager notificationManager = GetSystemService(NotificationService) as NotificationManager;

            const int notificationId = 1;
            notificationManager.Notify(notificationId, notification);
        }

        private void SimpleNotificationButton_Click(object sender, EventArgs e)
        {
            Notification.Builder builder = new Notification.Builder(this)
                                            .SetContentTitle("Base Layout Notification")
                                            .SetContentText("A Simple Hello World Notification")
                                            .SetSmallIcon(Resource.Drawable.notifcation_icon);

            Notification notification = builder.Build();

            NotificationManager notificationManager = GetSystemService(NotificationService) as NotificationManager;

            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);
        }
    }
}

