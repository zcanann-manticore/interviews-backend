namespace Server.Models
{
    public class LeaderboardEntry
    {
        public DateTime Date { get; set; }

        public int Score { get; set; }
    }

    public class LeaderboardFilterArgs
    {
        public int MinimumScore { get; set; }

        public LeaderboardSortOrder SortOrder { get; set; }
    }

    public enum LeaderboardSortOrder
    {
        Ascending,
        Descending,
    }
}
