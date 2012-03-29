using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Take1.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Take1.Models
{
    public class resultsDBcontext : DbContext
    {
        public DbSet<Result> Results { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}