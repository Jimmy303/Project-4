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
    [Activity(Label = "Club Standing", MainLauncher = false)]
    public class ClubStandingDetail : Activity
    {
        private TextView ClubNameText;
        private TextView MatchesPlayedText;
        private TextView WinsText;
        private TextView DrawsText;
        private TextView LossText;
        private TextView GoalsForText;
        private TextView GoalsAgainstText;
        private TextView GoalsDifferenceText;
        private TextView PointsText;
        private Button BACKButton;
        private Button COMPAREButton;

        private clubs_standings SelectedStanding;
        private ClubStandingsRepository clubStandingsRepository;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ClubStandingDetail);

            clubStandingsRepository = new ClubStandingsRepository();
            var SelectedClub = Intent.Extras.GetString("Selectedclub");
            SelectedStanding = clubStandingsRepository.GetClubs_Standing(SelectedClub);
    
            FindViews();
            BindData();
            HandleEvents();

        }

        private void FindViews()
        {
            ClubNameText = FindViewById<TextView>(Resource.Id.Name);
            MatchesPlayedText = FindViewById<TextView>(Resource.Id.MatchesPlayed);
            WinsText = FindViewById<TextView>(Resource.Id.Wins);
            DrawsText = FindViewById<TextView>(Resource.Id.Draws);
            LossText = FindViewById<TextView>(Resource.Id.Loss);
            GoalsForText = FindViewById<TextView>(Resource.Id.GoalsFor);
            GoalsAgainstText = FindViewById<TextView>(Resource.Id.GoalsAgainst);
            GoalsDifferenceText = FindViewById<TextView>(Resource.Id.GoalDifference);
            PointsText = FindViewById<TextView>(Resource.Id.Points);
            BACKButton = FindViewById<Button>(Resource.Id.back);
            COMPAREButton = FindViewById<Button>(Resource.Id.compare);
        }
        private void BindData()
        {
            ClubNameText.Text = SelectedStanding.Name;
            MatchesPlayedText.Text = "Matches Played: " + SelectedStanding.Matches_Played;
            WinsText.Text = "Wins: " + SelectedStanding.Wins;
            DrawsText.Text = "Draws: " + SelectedStanding.Draws;
            LossText.Text = "Loss: " + SelectedStanding.Loss;
            GoalsForText.Text = "Goals For: " + SelectedStanding.Goals_For;
            GoalsAgainstText.Text = "Goals Against: " + SelectedStanding.Goals_Against;
            GoalsDifferenceText.Text = "Goals Difference: " + SelectedStanding.Goal_Difference;
            PointsText.Text = "Points: " + SelectedStanding.Points;
        }
        private void HandleEvents()
        {
            BACKButton.Click += BACKButton_Click;
            COMPAREButton.Click += COMPAREButton_Click;
        }

        private void COMPAREButton_Click(object sender, EventArgs e)
        {
            var dialog = new AlertDialog.Builder(this);
            dialog.SetTitle("Onder constructie");
            dialog.SetMessage("werkt wel maar moet nog aangepast worden!");
            dialog.Show();
        }

        private void BACKButton_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}