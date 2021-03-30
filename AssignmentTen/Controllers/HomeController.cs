using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssignmentTen.Models;
using AssignmentTen.Models.ViewModels;

namespace AssignmentTen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BowlingLeagueContext _context;

        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(string? teamname, long? teamid, int pagenumber)
        {
            // amount of visible items
            int pageSize = 3;
            // get teams from context
            // if team selected
            // get everything in model
            BowlerListViewModel bowlerList = new BowlerListViewModel
            {
                BowlerList = _context.Bowlers.Where(b => b.TeamId == teamid || teamid == null).Skip((pagenumber- 1) * pageSize).Take(pageSize).ToList(),
                PagingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pagenumber,
                    TotalNumItems = teamid == null ? _context.Bowlers.Count() :
                    _context.Bowlers.Where(b => b.TeamId == teamid).Count()

                },
                TeamName = teamname != null ? teamname : "Home"
            };
                
            
          
                return View(bowlerList);
            
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
