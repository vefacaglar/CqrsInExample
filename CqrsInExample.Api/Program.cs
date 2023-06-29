using CqrsInExample.Application.Utils;
using CqrsInExample.Data.GamesContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration;

var config = new Config(3); // Deserialize from appsettings.json
builder.Services.AddSingleton(config);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<Messages>();
builder.Services.AddDbContext<GamesDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:GamesDb"]));
builder.Services.AddHandlers();

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
