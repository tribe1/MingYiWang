using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;

namespace MingYiWang.DataAccess.SqLite
{
    public class SqLiteContext : DbContext
    {
        //private static string cs = null;
        //private const string DB_FILE_NAME = @"App_Data\mingyiwang.db";
        //public static string ConnectionString
        //{
        //    get
        //    {
        //        return cs ?? (cs = string.Format(@"Data Source={0};Pooling=true;", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_FILE_NAME)));
        //    }
        //}

        //private static string connectionString = ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;
        //private SQLiteConnection connection = new SQLiteConnection(ConnectionString);
        //private DbContext _dbContext;

        public SqLiteContext()
            : base("sqlite")
        {

        }


        //// Constructor to use on a DbConnection that is already opened




    }
}
