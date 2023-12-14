using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}

public class MatchupEntryModel
{
    /// <summary>
    /// Represents one team in the matchup. 
    /// </summary>
    public TeamModel TeamCompeting { get; set; }

    /// <summary>
    /// Represents score for particular team.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// Represents the matchup that this 
    /// team came from as the winner
    /// </summary>
    public MatchupModel ParentMatchup { get; set; }

}





