using System.Reflection;
using FragmenticaManagmentCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FragmenticaManagmentMigrations;

public class FragmenticaManagmentContext : IDesignTimeDbContextFactory<FragmenticaContext>
{
    public FragmenticaContext CreateDbContext(string[] args)
    {
        var connectionString = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", false, true)
            .Build()
            .GetConnectionString("DefaultConnection");
        var builder = new DbContextOptionsBuilder<FragmenticaContext>()
            .UseSqlServer(connectionString);

        return new FragmenticaContext(builder.Options);
    }
}
