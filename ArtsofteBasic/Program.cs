

using System.Data;
using ArtsofteBasic.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.Extensions.Options;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// read connection string section
var db = builder.Configuration.GetConnectionString("postgres");

if (db == null || db.Equals(""))
{
    throw new Exception("db string is empty");
}
builder.Services.AddDbContext<ArtsofteContext>(opt => opt.UseNpgsql(db));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
using var scope = app.Services.CreateScope();
(scope.ServiceProvider.GetService<ArtsofteContext>() ?? throw new Exception(message: "Can't migrate database"))
    .Database.Migrate();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Migrator.Run<ArtsofteContext, Program>(args);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

internal class Db
{
    public string Host { get; init; } = string.Empty;
    public int Port { get; init; }
    public string Username { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
}
public record DbDescription(
    string Host,
    int Port,
    string Username,
    string Password,
    string Name)
{
}

public class StartMetadata
{
    public string Environment { get; init; }
    public string ServiceName { get; init; }
    public string SubService { get; init; }
    public string ServiceVersion { get; init; }
    public SwaggerUsage UseSwagger { get; init; }
    public string RoutingName { get; init; }
}
public enum SwaggerUsage
{
    Local,
    Environment,
    None,
}