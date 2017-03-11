using MingYiWang.Business.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace MingYiWang.DataAccess.MySql
{
    public class UserContext : MySqlContext
    {
        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("user");
        }


        public void Save()
        {
            base.SaveChanges();
        }

    }
}
