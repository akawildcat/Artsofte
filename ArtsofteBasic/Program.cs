

using ArtsofteBasic.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// read options section
// var db = builder.Configuration.GetSection(nameof(Db)).Get<Db>();
// // builder.Services.AddDatabase<TaskManagerContext>(dbDescription);
// var metadata = builder.Configuration.GetSection(nameof(StartMetadata)).Get<StartMetadata>();
// var dbDescription = new DbDescription(
//     Host: db.Host,
//     Port: db.Port,
//     Username: db.Username,
//     Password: db.Password,
//     Name: string.Join("_", new[] { metadata?.Environment, db.Name }.Where(s => !string.IsNullOrEmpty(s)))
// );
// builder.Services.AddSingleton<DbDescription>(dbDescription);





// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ArtsofteContext>();

// Migrator.Run<ArtsofteContext, Program>(args);

var app = builder.Build();

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