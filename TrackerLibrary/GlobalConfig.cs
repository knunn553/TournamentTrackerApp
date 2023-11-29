﻿using System;
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
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database == true)
            {
                
                // TODO - Setup SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);


            }
            if (textFiles == true)
            {        
                // TODO - Create the Text Connection
                TextConnector Text = new TextConnector();
                Connections.Add(Text);
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
