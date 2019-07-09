﻿namespace DR2Rallymaster.Models
{
    // This represents the JSON result returned for the "recentResults" endpoint
    // Contains information about the recent events and what stages they contain
    // Example URL:
    // https://dirtrally2.com/api/Club/183582/recentResults
    // no params

    public class RecentResultsApiModel
    {
        public ChampionshipEvents[] Championships { get; set; }
    }

    public class ChampionshipEvents
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Events[] Events { get; set; }
    }

    public class Events
    {
        public string Id { get; set; }
        public string ChallengeId { get; set; }
        public string Name { get; set; }
        public Stage[] Stages { get; set; }
    }

    public class Stage
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

}
