﻿using Android.App;
using Android.OS;
using Android.Widget;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo", Theme = "@style/NoTitle.splash")]
    public class IndependentAnimalActivity : Activity {

        public static Animal Animal
        {
            get; set;
        }

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.AnimalPage);
            FindViewById<ImageView>(Resource.Id.HeaderImage).SetImageResource(Animal.Image);
            FindViewById<TextView>(Resource.Id.Name).Text = Animal.Name;
            FindViewById<TextView>(Resource.Id.LatinName).Text = Animal.LatinName;
            FindViewById<TextView>(Resource.Id.AboutAnimal).Text = Animal.Description;
            if (Animal.HasFeedingTime)
                FindViewById<TextView>(Resource.Id.Feedingtime).Text = Animal.NextFeeding.ToString();
            else
                FindViewById<TextView>(Resource.Id.Feedingtime).Text = "(REPLACE) No feeding times.";

            Button mapButton = FindViewById<Button>(Resource.Id.mapButton);

            mapButton.Click += delegate {
                MapActivity.goToPlace = true;
                MapActivity.PlaceToGo = Animal.Location;
                StartActivity(typeof(MapActivity));
            };
        }
    }
}