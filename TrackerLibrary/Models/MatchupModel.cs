using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Unique Id for the matchups
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// Represents List of match ups
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Unique Identifier of the Winner
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// Represents winners of the matchups
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round of the tournament
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
