using MingYiWang.Business.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;

namespace MingYiWang.DataAccess.SqLite
{
    public class UserContext : SqLiteContext
    {
        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions
                 .Remove<PluralizingTableNameConvention>();
        }


        public void Save()
        {
            base.SaveChanges();
        }

    }
}
