using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents each team
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// List of teammember names
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
