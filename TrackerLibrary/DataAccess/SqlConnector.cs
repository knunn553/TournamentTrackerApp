using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    // ADO.NET is a little more complex than Dapper
    // Dapper makes connecting to a relational database, SQL, easier for a developer.
    // We could use Entity.Framework, which is more complex.
    // The first thing we need to do is use Dapper with a connection string.
    // We have to have in our app.config, a connections string.
    // We need to add an app.config file.
    // Gotta check out connection strings for SQL. Tim Corey has some on his website.
    // If we want to hard code the connection string along with the database name, it's important to include "Initial Catalog" as seen below
    // conn Data Source = KYLENUNND4C4; Initial Catalog = Tournaments; Integrated Security = True; Trust Server Certificate = True
    
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                // This is saying, we want to build a new IDbConnection.

                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
                return model;

            }
        }

        // TODO Make the CreatePrize method actually save to the database
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // We now have to put some kind of code in here that does omething
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                // This is saying, we want to build a new IDbConnection.
               
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
                return model;

            }
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                // This is saying, we want to build a new IDbConnection.

                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");

                foreach(PersonModel tm in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", tm.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }
                return model;

            }
        }

        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                // This is saying, we want to build a new IDbConnection.

                SaveTournament(connection, model);
                SaveTournamentPrizes(connection, model);
                SaveTournamentEntries(connection, model);


                return model;
            }
        }

        private void SaveTournament(IDbConnection connection,TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@id");
        }
        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel pz in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", pz.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {

            foreach (TeamModel tm in model.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", tm.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }

        }
        

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;

        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach(TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p,commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }
    }
}
