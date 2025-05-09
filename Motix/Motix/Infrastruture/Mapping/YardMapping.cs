
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Motix.API.Domain;

namespace Motix.API.Infrastructure.Mapping
{
    public class YardMapping : IEntityTypeConfiguration<Yard>
    {
        public void Configure(EntityTypeBuilder<Yard> builder)
        {
            builder.ToTable("Yards");

            builder.HasKey(y => y.Id);
            builder.Property(y => y.Name).HasMaxLength(100).IsRequired();
            builder.Property(y => y.Location).HasMaxLength(200).IsRequired();

           
            builder.HasMany(y => y.Sectors)
                .WithOne(s => s.Yard)
                .HasForeignKey(s => s.YardId);
        }
    }
}
