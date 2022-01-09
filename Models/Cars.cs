using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Garage.Models
{
    public partial class Cars : DbContext
    {
        public Cars()
            : base("name=Cars")
        {
        }
        public DbSet<Cars> cars;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
