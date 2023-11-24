﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary;

namespace TrackerLibrary
{
    public class PersonModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { get; set; }
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





