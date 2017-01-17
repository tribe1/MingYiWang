using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace MingYiWang.DataAccess.MySql
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DoctorContext : DbContext
    {

    }
}
