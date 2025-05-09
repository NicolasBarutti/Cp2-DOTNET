
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Motix.API.Domain;

namespace Motix.API.Infrastructure.Mapping
{
    public class SectorMapping : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable("Sectors");

            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).HasMaxLength(50).IsRequired();

          
            builder.HasOne(s => s.Yard)
                .WithMany(y => y.Sectors)
                .HasForeignKey(s => s.YardId);
        }
    }
}
