using Trabalho_so2.Services.Implementations;
using Trabalho_so2.Services;
using Trabalho_so2.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
var connection = Configuration["MySQLConnection:MySQLConnetionString"];
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(8,4,0) )));



builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();
 


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
