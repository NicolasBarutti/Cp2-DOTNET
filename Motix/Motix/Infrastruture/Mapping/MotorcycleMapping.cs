
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Motix.API.Domain;

namespace Motix.API.Infrastructure.Mapping
{
    public class MotorcycleMapping : IEntityTypeConfiguration<Motorcycle>
    {
        public void Configure(EntityTypeBuilder<Motorcycle> builder)
        {
            builder.ToTable("Motorcycles");

            builder.HasKey(m => m.Id);
            builder.Property(m => m.LicensePlate).HasMaxLength(20).IsRequired(false);
            builder.Property(m => m.Chassis).HasMaxLength(50).IsRequired(false);
            builder.Property(m => m.EntryDate).IsRequired();
            builder.Property(m => m.IsActive).IsRequired();

            
            builder.HasOne(m => m.Sector)
                .WithMany()
                .HasForeignKey(m => m.SectorId);
        }
    }
}
