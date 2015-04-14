using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Amap.Api.Maps2d;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    [MetaData("com.amap.api.v2.apikey", Value = "your-apikey")]
    public class MainActivity : Activity
    {
        private Com.Amap.Api.Maps2d.MapView mapView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var contentView = LayoutInflater.Inflate(Resource.Layout.Main, null);
            SetContentView(contentView);
            mapView = new MapView(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
            };
            mapView.OnCreate(bundle);
            (contentView.Parent.Parent as LinearLayout).AddView(mapView);
        }

        #region init

        protected override void OnResume()
        {
            base.OnResume();
            mapView.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
            mapView.OnPause();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            mapView.OnSaveInstanceState(outState);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            mapView.OnDestroy();
        }
        #endregion
    }
}

