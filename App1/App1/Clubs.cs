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

namespace App1
{
    [Activity(Label = "Clubs")]
    public class Clubs : Activity
    {
        private Button feyenoord;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here!
            SetContentView(Resource.Layout.Clubs);
            feyenoord = FindViewById<Button>(Resource.Id.feyknop);

            feyenoord.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Feyenoord));
                StartActivity(intent);
            };
        }
    }
}