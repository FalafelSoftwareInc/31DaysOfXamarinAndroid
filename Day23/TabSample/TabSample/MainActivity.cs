using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Fragment = Android.Support.V4.App.Fragment;

namespace TabSample
{
    [Activity(Label = "TabSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : FragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.main);

            var fragments = new Fragment[]
            {
                new PeopleFragment(),
                new FilmsFragment(),
                new StarshipsFragment(),
                new VehiclesFragment(),
                new SpeciesFragment(),
                new PlanetsFragment()
            };


            var titles = CharSequence.ArrayFromStringArray(new[]
                {
                    "People",
                    "Films",
                    "Starships",
                    "Vehicles",
                    "Species",
                    "Planets"
                });

            var viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);
            viewPager.Adapter = new TabsFragmentPagerAdapter(SupportFragmentManager, fragments, titles);

            // Give the TabLayout the ViewPager
            var tabLayout = FindViewById<TabLayout>(Resource.Id.sliding_tabs);
            tabLayout.SetupWithViewPager(viewPager);
        }
    }
}

