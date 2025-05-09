
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Motix.API.Domain;

namespace Motix.API.Infrastructure.Mapping
{
    public class MovementMapping : IEntityTypeConfiguration<Movement>
    {
        public void Configure(EntityTypeBuilder<Movement> builder)
        {
            builder.ToTable("Movements");

            builder.HasKey(m => m.Id);
            builder.Property(m => m.MovementDate).IsRequired();

            
            builder.HasOne(m => m.Motorcycle)
                .WithMany()
                .HasForeignKey(m => m.MotorcycleId);

            builder.HasOne(m => m.OriginSector)
                .WithMany()
                .HasForeignKey(m => m.OriginSectorId);

            builder.HasOne(m => m.DestinationSector)
                .WithMany()
                .HasForeignKey(m => m.DestinationSectorId);
        }
    }
}

