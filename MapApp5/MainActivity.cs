using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using MapApp5;

namespace MapTest5
{
    [Activity(Label = "MapTest5", MainLauncher = true)]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        

        private LatLngBounds AUSTRALIA = new LatLngBounds(
        new LatLng(-44, 113), new LatLng(-10, 154));

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            MapFragment mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            LatLng belmont = new LatLng(-31.9798264, 115.7799933);

            CameraUpdate camera = CameraUpdateFactory.NewLatLngZoom(belmont, 15);

            MarkerOptions markerOptions = new MarkerOptions();
            markerOptions.SetPosition(new LatLng(-31.9798264, 115.7799933));
            markerOptions.SetTitle("Claremont Trails");
            markerOptions.SetSnippet("Start Here");
            googleMap.AddMarker(markerOptions);

            MarkerOptions markerOptions2 = new MarkerOptions();
            markerOptions2.SetPosition(new LatLng(-31.980699, 115.7813756));
            markerOptions2.SetTitle("Claremont Trails Finish");
            markerOptions2.SetSnippet("End Here");
            googleMap.AddMarker(markerOptions2);

            //Optional fluff
            googleMap.UiSettings.ZoomControlsEnabled = true;
            googleMap.UiSettings.CompassEnabled = true;
            googleMap.MoveCamera(CameraUpdateFactory.ZoomIn());
            googleMap.UiSettings.ZoomGesturesEnabled = false;

        }

    }
}

