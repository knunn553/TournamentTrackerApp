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
        // TODO Make the CreatePrize method actually save to the database
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // We now have to put some kind of code in here that does omething
            using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
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
    }
}
