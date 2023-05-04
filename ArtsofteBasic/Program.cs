

using System.Data;
using ArtsofteBasic.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.Extensions.Options;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// read connection string section
var db = builder.Configuration.GetConnectionString("mssql");

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

app.UseHttpsRedirection();

// app.MapControllers();

app.Run();
