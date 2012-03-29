using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Take1.Models
{
    public class Result
    {
        public int fixtureID { get; set; }
        public string date { get; set; }
        public string ateam { get; set; }
        public string hteam { get; set; }
        public string ateamgoal { get; set; }
        public string hteamgoal { get; set; }
        public string idnum { get; set; }
    }
}