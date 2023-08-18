using FragmenticaManagmentCore;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1;

public class FragmenticaContext : DbContext
{
    public FragmenticaContext()
    {
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
    
    public DbSet<Perfume> Perfumes { get; set; }

}