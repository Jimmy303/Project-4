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
using SQLite.Models;
using SQLite.Repository;

namespace SQLite
{
    [Activity(Label = "Uitslagen")]
    public class Uitslagen : Activity
    {

        private ListView StandingsListview;
        private List<clubs_standings> clubs_Standings;
        private ClubStandingsRepository clubStandingsRepository;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Uitslagen);

            StandingsListview = FindViewById<ListView>(Resource.Id.STANDINGSLIST);
            clubStandingsRepository = new ClubStandingsRepository();
            clubs_Standings = clubStandingsRepository.GetClubs_Standings();
        }
    }
}