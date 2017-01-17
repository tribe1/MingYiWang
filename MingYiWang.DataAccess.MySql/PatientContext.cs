using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.DataAccess.MySql
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class PatientContext : DbContext
    {


    }
}
