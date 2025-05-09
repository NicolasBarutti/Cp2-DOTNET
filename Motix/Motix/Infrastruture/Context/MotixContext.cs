
using Microsoft.EntityFrameworkCore;
using Motix.API.Domain;
using Motix.API.Infrastructure.Mapping;

namespace Motix.API.Infrastructure.Context
{
    public class MotixContext : DbContext
    {
       
        public MotixContext(DbContextOptions<MotixContext> options) : base(options)
        { }

       
        public DbSet<Yard> Yards { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Movement> Movements { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new YardMapping());
            modelBuilder.ApplyConfiguration(new SectorMapping());
            modelBuilder.ApplyConfiguration(new MotorcycleMapping());
            modelBuilder.ApplyConfiguration(new MovementMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}

