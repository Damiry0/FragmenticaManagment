using FragmenticaManagmentCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FragmenticaManagmentCore.Repository.Configuration;

public class PerfumeConfiguration : IEntityTypeConfiguration<Perfume>
{
    public void Configure(EntityTypeBuilder<Perfume> builder)
    {
        builder.OwnsMany(p => p.Accords);
    }
}
