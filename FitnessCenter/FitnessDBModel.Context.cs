namespace FitnessCenter
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GymDBEntities : DbContext
    {
        public GymDBEntities()
            : base("name=GymDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }
    }
}
