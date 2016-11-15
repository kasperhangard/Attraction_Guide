using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GuidR.Droid
{
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    class PlaygroundMenuActivity : Activity
    {
        public static Facility Facility { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PlaygroundMenu);

            Button playground1_irl = FindViewById<Button>(Resource.Id.playGround1_irl);
            Button playground2_irl = FindViewById<Button>(Resource.Id.playGround2_irl);

            playground1_irl.Click += delegate
            {
                LoadPlayGround(AttractionDataBase.PlaygroundKiosk);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

            playground2_irl.Click += delegate
            {
                LoadPlayGround(AttractionDataBase.PlaygroundKiosk);
                MapActivity.Attraction = Facility;
                StartActivity(typeof(MapActivity));
            };

        }
        public void LoadPlayGround(Facility facility)
        {
            PlaygroundMenuActivity.Facility = facility;
        }
    }
}