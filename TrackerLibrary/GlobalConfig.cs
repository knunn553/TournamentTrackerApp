using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        // System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=KYLENUNND4C4;Initial Catalog=SensorSystems;Integrated Security=True");
        // System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=KYLENUNND4C4;Initial Catalog=SensorSystems;Integrated Security=True");
        // The above code is if we were looking into hardcoding the connection string. We would need to add "Initial Catalog"
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {                
                // TODO - Setup SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        public static string CnnString(string name)
            // What this will do is go to the app.config and get the connection string.
            // By calling GlobalConfig.CnnString and calling the Tournaments name, we can use the connection string for Tournaments anywhere in our app.
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

           
        }
    }
}
