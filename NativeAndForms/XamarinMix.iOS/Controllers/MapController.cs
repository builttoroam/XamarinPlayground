using MapKit;
using UIKit;

namespace XamarinMix.iOS.Controllers
{
    public class MapController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var mapView = new MKMapView(UIScreen.MainScreen.Bounds);
            View.Add(mapView);
        }
    }
}