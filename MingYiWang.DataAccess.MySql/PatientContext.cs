using MingYiWang.Business.Model;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.DataAccess.MySql
{
    //https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework60.html

    
    public class PatientContext : MySqlContext
    {

        public DbSet<Patient> Patients { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Patient>().ToTable("patient");
        }


        public void Save()
        {
            base.SaveChanges();
        }

    }
}
