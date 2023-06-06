using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Unique Id for the matchup entries
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the unique identifier for the team
        /// </summary>
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents score of the particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// The unique identifier for the parent matchup of the team
        /// </summary>
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Represents the matchup that this team came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        public double InitialScore { get; set; }
    }
}
