using Android.App;
using Android.OS;
using Android.Views;

namespace FragmentSamples
{
    public class AboutFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.About, container, false);
        }
    }
}