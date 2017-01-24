using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace MingYiWang.DataAccess.MySql
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MySqlContext : DbContext
    {


        private static string connectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
        private MySqlConnection connection = new MySqlConnection(connectionString);
        private DbContext _dbContext;
        public MySqlContext()
      : base(connectionString)
        {

            connection.Open();
            _dbContext = new DbContext(connection, false);
        }

        // Constructor to use on a DbConnection that is already opened
        public MySqlContext(DbConnection existingConnection, bool contextOwnsConnection)
      : base(existingConnection, contextOwnsConnection)
        {

        }

        public DbContext MySqlDbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new DbContext(connection, false);
                }
                return _dbContext;
            }



        }

    }
}
