using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace SQLite
{
    [Activity(Label = "Clubs")]
    public class Clubs : Activity 
    {
        private Button feyenoord;
        private Button psv;
        private Button ajax;
        private Button az;
        private Button utrecht;
        private Button vitesse;
        private Button denhaag;
        private Button heerenveen;
        private Button zwolle;
        private Button heracles;
        private Button excelsior;
        private Button groningen;
        private Button willem;
        private Button nac;
        private Button vvv;
        private Button roda;
        private Button sparta;
        private Button twente;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here!
            SetContentView(Resource.Layout.Clubs);

            feyenoord = FindViewById<Button>(Resource.Id.feyenoord);

            feyenoord.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Feyenoord));
                StartActivity(intent);
            };

            psv = FindViewById<Button>(Resource.Id.psv);

            psv.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(PSV));
                StartActivity(intent);
            };
            ajax = FindViewById<Button>(Resource.Id.ajax);

            ajax.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Ajax));
                StartActivity(intent);
            };
            az = FindViewById<Button>(Resource.Id.az);

            az.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(AZ));
                StartActivity(intent);
            };
            utrecht = FindViewById<Button>(Resource.Id.utrecht);

            utrecht.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Utrecht));
                StartActivity(intent);
            };
            vitesse = FindViewById<Button>(Resource.Id.vitesse);

            vitesse.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Vitesse));
                StartActivity(intent);
            };
            denhaag = FindViewById<Button>(Resource.Id.denhaag);

            denhaag.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Denhaag));
                StartActivity(intent);
            };
            heerenveen = FindViewById<Button>(Resource.Id.heerenveen);

            heerenveen.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Heerenveen));
                StartActivity(intent);
            };
            zwolle = FindViewById<Button>(Resource.Id.zwolle);

            zwolle.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Zwolle));
                StartActivity(intent);
            };
            heracles = FindViewById<Button>(Resource.Id.heracles);

            heracles.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Heracles));
                StartActivity(intent);
            };
            excelsior = FindViewById<Button>(Resource.Id.excelsior);

            excelsior.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Excelsior));
                StartActivity(intent);
            };
            groningen = FindViewById<Button>(Resource.Id.groningen);

            groningen.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Groningen));
                StartActivity(intent);
            };
            willem = FindViewById<Button>(Resource.Id.willem);

            willem.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Willem));
                StartActivity(intent);
            };
            nac = FindViewById<Button>(Resource.Id.nac);

            nac.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(NAC));
                StartActivity(intent);
            };
            vvv = FindViewById<Button>(Resource.Id.vvv);

            vvv.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(VVV));
                StartActivity(intent);
            };
            roda = FindViewById<Button>(Resource.Id.roda);

            roda.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Roda));
                StartActivity(intent);
            };
            sparta = FindViewById<Button>(Resource.Id.sparta);

            sparta.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Sparta));
                StartActivity(intent);
            };
            twente = FindViewById<Button>(Resource.Id.twente);

            twente.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Twente));
                StartActivity(intent);
            };


        }
    }
}