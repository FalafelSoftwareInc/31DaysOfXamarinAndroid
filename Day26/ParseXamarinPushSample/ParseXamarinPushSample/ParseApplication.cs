using System;
using Android.App;
using Android.Runtime;
using Parse;

namespace ParseXamarinPushSample
{
    [Application(Name = "parsexamarinpushsample.ParseApplication")]
    class ParseApplication : Application
    {
        public ParseApplication(IntPtr handle, JniHandleOwnership ownerShip)
          : base(handle, ownerShip)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            ParseClient.Initialize("<YOURAPPLICATIONID>", "<YOUR.NETKEY>");
            ParsePush.ParsePushNotificationReceived += ParsePush.DefaultParsePushNotificationReceivedHandler;
        }
    }
}