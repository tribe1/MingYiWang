using MingYiWang.Business.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace MingYiWang.DataAccess.MySql
{
    public class DeptContext : MySqlContext
    {

        public DbSet<Dept> Depts { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Dept>().ToTable("dept");
        }


        public void Save()
        {
            base.SaveChanges();
        }

    }
}
