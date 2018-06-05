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

namespace SQLite.Repository
{
    public class ClubStandingsRepository
    {
        private List<clubs_standings> clubs_Standings = new List<clubs_standings>() {
            new clubs_standings(){
                Name = "PSV Eindhoven",
                Matches_Played = 34,
                Wins = 26,
                Draws = 5,
                Loss = 3,
                Goals_For = 87,
                Goals_Against = 39,
                Goal_Difference = 48,
                Points = 83
            },
            new clubs_standings(){
                Name = "Ajax",
                Matches_Played = 34,
                Wins = 25,
                Draws = 4,
                Loss = 5,
                Goals_For = 89,
                Goals_Against = 33,
                Goal_Difference = 56,
                Points = 79
            },
             new clubs_standings(){
                Name = "AZ Alkmaar",
                Matches_Played = 34,
                Wins = 22,
                Draws = 5,
                Loss = 7,
                Goals_For = 72,
                Goals_Against = 38,
                Goal_Difference = 34,
                Points = 71
            },
              new clubs_standings(){
                Name = "Feyenoord",
                Matches_Played = 34,
                Wins = 20,
                Draws = 6,
                Loss = 8,
                Goals_For = 76,
                Goals_Against = 39,
                Goal_Difference = 37,
                Points = 66
            },
               new clubs_standings(){
                Name = "Utrecht",
                Matches_Played = 34,
                Wins = 14,
                Draws = 12,
                Loss = 8,
                Goals_For = 58,
                Goals_Against = 53,
                Goal_Difference = 5,
                Points = 54
            },
               new clubs_standings(){
                Name = "Vitesse",
                Matches_Played = 34,
                Wins = 13,
                Draws = 10,
                Loss = 11,
                Goals_For = 63,
                Goals_Against = 47,
                Goal_Difference = 16,
                Points = 49
            },
               new clubs_standings(){
                Name = "Den Haag",
                Matches_Played = 34,
                Wins = 13,
                Draws = 8,
                Loss = 13,
                Goals_For = 45,
                Goals_Against = 53,
                Goal_Difference = 8,
                Points = 47
            },
               new clubs_standings(){
                Name = "Heerenveen",
                Matches_Played = 34,
                Wins = 12,
                Draws = 10,
                Loss = 12,
                Goals_For = 48,
                Goals_Against = 53,
                Goal_Difference = -5,
                Points = 46
            },
               new clubs_standings(){
                Name = "Zwolle",
                Matches_Played = 34,
                Wins = 12,
                Draws = 8,
                Loss = 14,
                Goals_For = 42,
                Goals_Against = 54,
                Goal_Difference = -12,
                Points = 44
            },
               new clubs_standings(){
                Name = "Heracles",
                Matches_Played = 34,
                Wins = 11,
                Draws = 9,
                Loss = 14,
                Goals_For = 50,
                Goals_Against = 64,
                Goal_Difference = -14,
                Points = 42
            },
                new clubs_standings(){
                Name = "Excelcior",
                Matches_Played = 34,
                Wins = 11,
                Draws = 7,
                Loss = 16,
                Goals_For = 41,
                Goals_Against = 56,
                Goal_Difference = -15,
                Points = 40
            },
                new clubs_standings(){
                Name = "Groningen",
                Matches_Played = 34,
                Wins = 8,
                Draws = 14,
                Loss = 12,
                Goals_For = 50,
                Goals_Against = 50,
                Goal_Difference = 0,
                Points = 38
            },
                new clubs_standings(){
                Name = "Willem II",
                Matches_Played = 34,
                Wins = 10,
                Draws = 7,
                Loss = 17,
                Goals_For = 50,
                Goals_Against = 63,
                Goal_Difference = -13,
                Points = 37
            },
                new clubs_standings(){
                Name = "NAC",
                Matches_Played = 34,
                Wins = 9,
                Draws = 7,
                Loss = 18,
                Goals_For = 41,
                Goals_Against = 57,
                Goal_Difference = -16,
                Points = 34
            },
                new clubs_standings(){
                Name = "VVV",
                Matches_Played = 34,
                Wins = 7,
                Draws = 13,
                Loss = 14,
                Goals_For = 35,
                Goals_Against = 54,
                Goal_Difference = -19,
                Points = 34
            },
                new clubs_standings(){
                Name = "Roda",
                Matches_Played = 34,
                Wins = 8,
                Draws = 6,
                Loss = 20,
                Goals_For = 42,
                Goals_Against = 69,
                Goal_Difference = -27,
                Points = 30
            },
                new clubs_standings(){
                Name = "Sparta",
                Matches_Played = 34,
                Wins = 7,
                Draws = 6,
                Loss = 21,
                Goals_For = 34,
                Goals_Against = 75,
                Goal_Difference = -41,
                Points = 27
            },
                new clubs_standings(){
                Name = "Twente",
                Matches_Played = 34,
                Wins = 5,
                Draws = 9,
                Loss = 20,
                Goals_For = 37,
                Goals_Against = 63,
                Goal_Difference = -26,
                Points = 24
            }
        };

        public List<clubs_standings> GetClubs_Standings()
        {
            return clubs_Standings;
        }
        /// <summary>
        /// Search button bekijkt input string van user of deze in clubnamenlijst(data) staat.
        /// Deze geeft alle matches terug. Let op dat de clubnaam begint met een hoofdletter.
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public List<clubs_standings> Search(string Search)
        {
            return clubs_Standings.Where(C => C.Name.Contains(Search)).ToList();
        }

        public clubs_standings GetClubs_Standing(string name)
        {
            return clubs_Standings.Single(a => a.Name.Equals(name));
        }
    }
}