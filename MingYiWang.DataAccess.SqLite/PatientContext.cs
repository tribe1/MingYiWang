using MingYiWang.Business.Model;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.DataAccess.SqLite
{
    //https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework60.html

    
    public class PatientContext : SqLiteContext
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
