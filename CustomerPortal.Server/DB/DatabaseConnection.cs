using Microsoft.Data.SqlClient;

namespace CustomerPortal.Server.DB
{
    public class DatabaseConnection
    {
        private readonly string _connectionstring;
        public DatabaseConnection(string connectionString) 
        {
            _connectionstring = connectionString;
        }

        //originally i wanted to use EntityFramework, but i was having trouble with removing the invariant culture when trying to run update-database,
        //i looked for other alternatives, which was ADO.Net, but this was also having problems connecting to the database.

        public string ConnectToDatabase()
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    return "Opened successfully";
                }
                else 
                {
                    return connection.State.ToString();
                }
            }
        }
    }
}
