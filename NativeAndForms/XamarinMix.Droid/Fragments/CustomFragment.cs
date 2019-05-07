using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinMix.Forms;
using Application = Android.App.Application;
using View = Android.Views.View;

namespace XamarinMix.Droid.Fragments
{
    public class CustomFragment : Fragment
    {
        private readonly FragmentManager fragmentManager;

        public CustomFragment(FragmentManager fragmentManager)
        {
            this.fragmentManager = fragmentManager;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            var settingSupportFragment = new SettingsPage().CreateSupportFragment(Application.Context);

            fragmentManager.BeginTransaction()
                           .Replace(Resource.Id.settings_page_fragment_placeholder, settingSupportFragment)
                           .Commit();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.custom_layout, container, false);
        }
    }
}