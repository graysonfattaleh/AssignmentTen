using System;
using System.Linq;
using AssignmentTen.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentTen.Components
{
    public class TeamNameViewComponent : ViewComponent
    {

        // make context
        private BowlingLeagueContext _context;
        public TeamNameViewComponent(BowlingLeagueContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            // returns all unique team names 
            return View(_context.Teams.Distinct().OrderBy(x=>x));
        }

    }
}
