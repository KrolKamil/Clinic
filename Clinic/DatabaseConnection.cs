using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clinic
{
    static class DatabaseConnection
    {
        public static MySqlConnection Connection()
        {
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();

            connectionStringBuilder.Port = uint.Parse(DatabaseConfiguration.port);
            connectionStringBuilder.Server = DatabaseConfiguration.database;
            connectionStringBuilder.UserID = DatabaseConfiguration.user;
            connectionStringBuilder.Password = DatabaseConfiguration.password;
            connectionStringBuilder.Database = DatabaseConfiguration.database;

            MySqlConnection connection = new MySqlConnection(connectionStringBuilder.ToString());

            return connection;
        }
    }
}
