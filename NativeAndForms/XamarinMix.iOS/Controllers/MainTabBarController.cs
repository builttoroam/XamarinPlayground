using UIKit;
using Xamarin.Forms.Platform.iOS;
using XamarinMix.Forms;

namespace XamarinMix.iOS.Controllers
{
    public class MainTabBarController : UITabBarController
    {
        private readonly UIViewController mapTab;
        private readonly UIViewController settingsTab;

        public MainTabBarController()
        {
            mapTab = new MapController
            {
                TabBarItem = new UITabBarItem
                {
                    Image = UIImage.FromFile("Icons/globe.png")
                },
                View =
                {
                    BackgroundColor = UIColor.Green
                }
            };

            var settingsPage = new SettingsPage().CreateViewController();
            settingsPage.TabBarItem = new UITabBarItem
            {
                Image = UIImage.FromFile("Icons/settings.png")
            };
            settingsPage.View.BackgroundColor = UIColor.Green;

            var tabs = new UIViewController[]
            {
                mapTab,
                settingsPage
            };

            ViewControllers = tabs;
        }
    }
}