namespace MatterManager.Persistence
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MatterManagerContext : DbContext
    {
        public MatterManagerContext(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<Matter> Matters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
