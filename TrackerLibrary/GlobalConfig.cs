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
        public const string PrizesFile = "PrizeModel.csv";
        public const string PersonFile = "PersonModel.csv";
        public const string TeamFile = "TeamModel.csv";
        public const string TournamentFile = "TournamentModel.csv";
        public const string MatchupFile = "MatchupModel.csv";
        public const string MatchupEntryFile = "MatchupEntryModel.csv";
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(databaseType db) 
        {
            if (db == databaseType.Sql)
            {
                // TODO - Set up sql connecter properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(db == databaseType.TextFile) 
            {
                // TODO - Create Text connection
                TextConnector text = new TextConnector(); 
                Connection = text;
            }

        }

        public static string connectionString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString; 
        }
    }
}
