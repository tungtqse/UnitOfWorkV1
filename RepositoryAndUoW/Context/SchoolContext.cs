using RepositoryAndUoW.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAndUoW.Context
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() { }
        public SchoolContext(string connectionStringName) : base(connectionStringName) { }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
