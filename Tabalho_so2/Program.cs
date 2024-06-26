using Trabalho_so2.Business.Implementations;
using Trabalho_so2.Business;
using Trabalho_so2.Model.Context;
using Microsoft.EntityFrameworkCore;
using Trabalho_so2.Repository.Implementations;
using Trabalho_so2.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

var connection = builder.Configuration.GetConnectionString("MySQLConnectionString");


builder.Services.AddDbContext<MySQLContext>(options =>
    options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 23))));

// Add API versioning


// Register repositories and business services
builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementations>();
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementations>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
