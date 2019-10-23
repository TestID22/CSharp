namespace EntityF_CodeFirstfromDB_.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AutoLotEntities : DbContext
    {
        public AutoLotEntities()
            : base("name=AutoLotEntities")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Car)
                .HasForeignKey(e => e.OrderId)
                .WillCascadeOnDelete(false);
        }
    }
}
