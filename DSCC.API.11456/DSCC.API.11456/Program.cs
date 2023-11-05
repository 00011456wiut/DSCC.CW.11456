using Microsoft.EntityFrameworkCore;
using DSCC.API._11456.Context;
using DSCC.API._11456.Interfaces;
using DSCC.API._11456.Repositories;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<UniContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UniDB")));
builder.Services.AddScoped<IBlogRepository, BlogRepository>(); 
builder.Services.AddScoped<IUniversityRepository, UniversityRepository>(); 



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

