using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EF_poc.data
{
    class DBContext : DbContext
    {
        public DBContext(string connectionString = "BIMDbConnectionString") : base(connectionString) {
            
        }

        public virtual DbSet<BimModel> BimModel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
