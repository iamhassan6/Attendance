namespace FirstP.DATA
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<Depart> Departs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Atten> Attens { get; set; }
        public virtual DbSet<Black> Blacks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.PHS)
                .HasPrecision(18, 0);
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
