﻿using Android.App;
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
        public void OnMapReady(GoogleMap googleMap)
        {
            MarkerOptions markerOptions = new MarkerOptions();
            markerOptions.SetPosition(new LatLng(16.03, 108));
            markerOptions.SetTitle("My Position");
            googleMap.AddMarker(markerOptions);



            //Optional fluff
            googleMap.UiSettings.ZoomControlsEnabled = true;
            googleMap.UiSettings.CompassEnabled = true;
            googleMap.MoveCamera(CameraUpdateFactory.ZoomIn());
        }



        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            MapFragment mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }
    }
}

