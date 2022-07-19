namespace Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Server.Models;

    [ApiController]
    [Route("[controller]")]
    public class LeaderboardController : ControllerBase
    {
        private static readonly string[] Usernames = new[]
        {
            "Jane", "John"
        };

        private readonly ILogger<LeaderboardController> _logger;

        public LeaderboardController(ILogger<LeaderboardController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLeaderboardEntries")]
        public IEnumerable<LeaderboardEntry> Get(/*int count, LeaderboardFilterArgs args*/)
        {
            return Enumerable.Range(1, 5).Select(index => new LeaderboardEntry
            {
                Date = DateTime.Now.AddDays(index),
                Score = Random.Shared.Next(0, 100),
            })
            .ToArray();
        }
    }
}
