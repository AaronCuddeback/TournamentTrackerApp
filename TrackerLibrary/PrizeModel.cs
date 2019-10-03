using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the prize results
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// What number the team places to get each prize
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// the name of each place in the tournament 
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// What dollar amount the team gets for each placement
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// what percentage of the total prize amount each place gets
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
