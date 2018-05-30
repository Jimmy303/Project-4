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

namespace SQLite
{
    [Activity(Label = "Profiel")]
    public class Profiel : Activity
    {
        private Button clubknop;
        private Button uitslagknop;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Profiel);
            // Create your application here
            clubknop = FindViewById<Button>(Resource.Id.profielknop2);

            clubknop.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Clubs));
                StartActivity(intent);
            };
            uitslagknop = FindViewById<Button>(Resource.Id.profielknop1);

            uitslagknop.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Uitslagen));
                StartActivity(intent);
            };
        }
    }
}