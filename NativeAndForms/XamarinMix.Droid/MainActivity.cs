using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using XamarinMix.Droid.Adapters;

namespace XamarinMix.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnMapReadyCallback, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        private BottomNavigationView bottomNavigation;
        private ViewPager viewPager;

        public void OnMapReady(GoogleMap googleMap)
        {
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.map_tab_item)
            {
                viewPager.SetCurrentItem(0, true);
            }

            if (item.ItemId == Resource.Id.settings_tab_item)
            {
                viewPager.SetCurrentItem(1, true);
            }

            return false;
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Xamarin.Forms.Forms.Init(this, bundle);

            viewPager = FindViewById<ViewPager>(Resource.Id.view_pager);
            viewPager.Adapter = new MainTabbedPageAdapter(SupportFragmentManager);

            bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNavigation?.SetOnNavigationItemSelectedListener(this);
        }
    }
}