using FragmenticaManagmentCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FragmenticaManagmentCore.Repository;

public class FragmenticaContext : DbContext
{
    public FragmenticaContext(DbContextOptions<FragmenticaContext> options) : base(options)
    {
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        /*var connectionString = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false, true)
            .Build()
            .GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);*/
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FragmenticaContext).Assembly);
    }
    
    public DbSet<Perfume> Perfumes { get; set; }

}