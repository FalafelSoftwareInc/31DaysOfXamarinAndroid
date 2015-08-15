using Android.App;
using Android.OS;
using Android.Views;

namespace FragmentSamples
{
    public class MyFragment : Fragment
    {
        public override void OnAttach(Activity activity)
        {
            base.OnAttach(activity);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
        }

        public override void OnStart()
        {
            base.OnStart();
        }

        public override void OnPause()
        {
            base.OnPause();
        }

        public override void OnStop()
        {
            base.OnStop();
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}