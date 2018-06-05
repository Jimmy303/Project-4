namespace SQLite.Models
{
    public class clubs_standings
    {
        public string Name { get; set; }
        public int Matches_Played { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loss { get; set; }
        public int Goals_For { get; set; }
        public int Goals_Against { get; set; }
        public int Goal_Difference { get; set; }
        public int Points { get; set; }

    }
}