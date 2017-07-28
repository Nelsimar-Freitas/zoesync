using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class MedicoContext : DbContext
    {
        public DbSet<Teste> Testes {get;set;}

        public MedicoContext() 
            : base(ConfigurationManager.ConnectionStrings["yesdoctormedicEntities"].ConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teste>().MapToStoredProcedures();
        }
    }
}