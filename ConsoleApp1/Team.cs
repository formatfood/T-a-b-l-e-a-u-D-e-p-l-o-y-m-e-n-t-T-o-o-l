using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Team
    {
        public double TotalCredits { get; set; }
        public int TeamACount { get; set; }
        public int TeamBCount { get; set; }
        public IList<Player> TeamPlayers { get; set; }
    }
}
