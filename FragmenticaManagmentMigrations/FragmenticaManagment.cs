using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FragmenticaManagmentMigrations;

public class FragmenticaManagmentContext : IDesignTimeDbContextFactory<FragmenticaContext>
{
    public FragmenticaContext CreateDbContext(string[] args)
    {
        var configurationBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false, true);
        var configuration = configurationBuilder.Build();
        var builder = new DbContextOptionsBuilder<FragmenticaContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        builder.UseSqlServer(connectionString);

        return new FragmenticaContext();
    }
}
