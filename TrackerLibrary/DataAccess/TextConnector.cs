﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
// We still need to create a solid path in the app.config file.
// 
namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizesModels.csv";
        private const string PeopleFile = "PersonModel.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";



        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            // We now need to find the max ID
            int currentId = 1;
            if(people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);

            return model;

        }

        // TODO Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load text file and Convert text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;
            
            if (prizes.Count > 0)
            {
               currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add new record with the new ID (max + 1)
            prizes.Add(model);

            // Convert the prizes to list<strings>
            // Save list<strings> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }

       

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);
            teams.SaveToTeamFile(TeamFile);
            return model;
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels(TeamFile, PeopleFile, PrizesFile);

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            tournaments.Add(model);
            tournaments.SaveToTournamentFile(TournamentFile);
        }
    }
}
