using CqrsInExample.Domain.Games;
using CqrsInExample.Infrastructure.GamesContext;
using Microsoft.EntityFrameworkCore;
using CqrsInExample.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GamesDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:GamesDb"]));
builder.Services.AddTransient<IMsSqlDbConnectionFactory, MsSqlConnectionFactory>();

builder.Services.AddInfrastructure();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(CreateGameCommand).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
