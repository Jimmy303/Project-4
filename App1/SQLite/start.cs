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
    [Activity(Label = "start", MainLauncher = true)]
    public class start : Activity
    {
        private Button Startknop;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.start);

            FindViews();
            HandleEvents();

        }
        private void FindViews()
        {
            Startknop = FindViewById<Button>(Resource.Id.startknop);
        }
        private void HandleEvents()
        {
            Startknop.Click += Startknop_Click;
        }

        private void Startknop_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
    }

}