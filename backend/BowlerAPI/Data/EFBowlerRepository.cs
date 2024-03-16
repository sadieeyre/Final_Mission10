﻿using BowlerAPI.Data;

using Microsoft.EntityFrameworkCore;
using static BowlerAPI.Data.EFBowlerRepository;

namespace BowlerAPI.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _bowlerContext;

        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers.Include(x => x.Team).ToList();
        public IEnumerable<Team> Teams => _bowlerContext.Teams;
    }
}