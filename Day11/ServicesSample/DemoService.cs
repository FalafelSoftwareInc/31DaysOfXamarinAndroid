using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;

namespace ServicesSample
{
    public class DemoService : Service
    {
        public override void OnStart(Intent intent, int startId)
        {
            base.OnStart(intent, startId);

            Log.Debug("DemoService", "OnStart DemoService");

            DoBackgroundWork();
        }


        public override void OnDestroy()
        {
            base.OnDestroy();

            Log.Debug("DemoService", "Destroying DemoService");
        }
        private void DoBackgroundWork()
        {
            Log.Debug("DemoService", "Doing Background work in the DemoService");
        }

        public override IBinder OnBind(Intent intent)
        {
            return null;   
        }
    }
}