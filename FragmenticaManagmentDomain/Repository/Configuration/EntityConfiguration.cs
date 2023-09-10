using FragmenticaManagmentCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FragmenticaManagmentCore.Repository;


    public class EntityConfiguration : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.Property(x => x.Ulid).HasConversion(new ValueConverter<Ulid, string>(
                v => v.ToString(),
                v => Ulid.Parse(v)));
        }
    }
