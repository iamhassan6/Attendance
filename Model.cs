namespace FirstP.DATA
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelData")
        {
        }

        public virtual DbSet<Atten> Attens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atten>()
                .Property(e => e.shft)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Atten>()
                .Property(e => e.hrs)
                .HasPrecision(18, 0);
        }
    }
}
