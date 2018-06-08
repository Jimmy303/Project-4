using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.Database.Sqlite;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Helper;

namespace SQLite
{
    [Activity(Label = "Utrecht")]
    public class Utrecht : Activity
    {
        DBHelper db;
        SQLiteDatabase sqliteDB;
        LinearLayout container;
        Button btnGetData;
        List<Speler> lstUser = new List<Speler>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Clubdata);

            db = new DBHelper(this);
            sqliteDB = db.WritableDatabase;

            container = FindViewById<LinearLayout>(Resource.Id.container);
            btnGetData = FindViewById<Button>(Resource.Id.btnGetData);
            btnGetData.Click += delegate
            {
                addData();
            };
            
        }

        private void addData()
        {
            ICursor selectData = sqliteDB.RawQuery("select * from Spelers where Club = 'FC Utrecht'", new string[]{ });
            if(selectData.Count > 0)
            {
                selectData.MoveToFirst();
                do
                {
                    Speler user = new Speler();
                    user.Club = selectData.GetString(selectData.GetColumnIndex("Club"));
                    user.Naam = selectData.GetString(selectData.GetColumnIndex("Naam"));
                    user.Leeftijd = selectData.GetString(selectData.GetColumnIndex("Leeftijd"));
                    user.Lengte = selectData.GetString(selectData.GetColumnIndex("Lengte"));
                    user.Positie = selectData.GetString(selectData.GetColumnIndex("Positie"));
                    user.Marktwaarde = selectData.GetString(selectData.GetColumnIndex("Marktwaarde"));

                    lstUser.Add(user);

                }
                while (selectData.MoveToNext());
                selectData.Close();

            }
            foreach(var item in lstUser)
            {
                LayoutInflater layoutInflater = (LayoutInflater)BaseContext.GetSystemService(Context.LayoutInflaterService);
                View addView = layoutInflater.Inflate(Resource.Layout.row, null);
                TextView txtclub = addView.FindViewById<TextView>(Resource.Id.txtclub);
                TextView txtnaam = addView.FindViewById<TextView>(Resource.Id.txtnaam);
                TextView txtleeftijd = addView.FindViewById<TextView>(Resource.Id.txtleeftijd);
                TextView txtlengte = addView.FindViewById<TextView>(Resource.Id.txtlengte);
                TextView txtpositie = addView.FindViewById<TextView>(Resource.Id.txtpositie);
                TextView txtmarktwaarde = addView.FindViewById<TextView>(Resource.Id.txtmarkt);

                txtclub.Text = item.Club;
                txtnaam.Text = item.Naam;
                txtleeftijd.Text = item.Leeftijd;
                txtlengte.Text = item.Lengte;
                txtpositie.Text = item.Positie;
                txtmarktwaarde.Text = item.Marktwaarde;

                container.AddView(addView);
            }
        }
    }
}