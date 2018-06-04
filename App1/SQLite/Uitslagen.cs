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
using SQLite.Adapters;
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

        private Button menuButton;
        private Button searchButton;
        private EditText searchBar;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Uitslagen);

            StandingsListview = FindViewById<ListView>(Resource.Id.STANDINGSLIST);
            clubStandingsRepository = new ClubStandingsRepository();
            clubs_Standings = clubStandingsRepository.GetClubs_Standings();
            StandingsListview.Adapter = new StandingsAdapter(this, clubs_Standings);
            StandingsListview.ItemClick += StandingsListview_ItemClick;


            FindViews();
            HandleEvents();

        }

        private void StandingsListview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var club = clubs_Standings[e.Position];

            var intent = new Intent();
            intent.SetClass(this, typeof(ClubStandingDetail));
            intent.PutExtra("Selectedclub", club.Name);

            StartActivityForResult(intent, 100);
        }

        private void FindViews()
        {
            menuButton = FindViewById<Button>(Resource.Id.menuButton);
            searchButton = FindViewById<Button>(Resource.Id.searchButton);
            searchBar = FindViewById<EditText>(Resource.Id.searchBar);

        }

        private void HandleEvents()
        {
            menuButton.Click += MenuButton_Click;
            searchButton.Click += SearchButton_Click;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchBar.Text;
            if (!String.IsNullOrWhiteSpace(searchText))
            {
                clubs_Standings = clubStandingsRepository.Search(searchText);
                StandingsListview.Adapter = new StandingsAdapter(this, clubs_Standings);
            } 
            else
            {
                clubs_Standings = clubStandingsRepository.GetClubs_Standings();
                StandingsListview.Adapter = new StandingsAdapter(this, clubs_Standings);
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Profiel));
            StartActivity(intent);
        }
    }
}