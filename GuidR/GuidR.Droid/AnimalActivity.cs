using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GuidR.Droid {
    [Activity(Label = "Aalborg Zoo")]
    public class animalActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Animals);
        }

    }


}