using System;
using System.Collections.Generic;

namespace AssignmentTen.Models.ViewModels
{
    public class BowlerListViewModel
    {
       public List<Bowler> BowlerList { get; set; }

        public PageNumberingInfo PagingInfo { get; set; }

        public string TeamName { get; set; }
    }
}
