using System.Reflection;
using FragmenticaManagmentCore.Repository;
using FragmenticaManagmentInfrastracture;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAdB2C"));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddControllers( options =>
{
    options.Filters.Add(typeof(ExceptionFilter));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<DbContext, FragmenticaContext>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddDbContext<FragmenticaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), options =>
    {
        options.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
        options.MigrationsAssembly("FragmenticaManagmentMigrations");
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();