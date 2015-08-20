using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace TabSample
{
    public class FilmsFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.Films, container, false);
        }
    }
}