using Move.Dataleryer;
using Move.Repository;
using Microsoft.EntityFrameworkCore;
using Move.Dataleryer;
using Move.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IService, Service>();
builder.Services.AddScoped<IAccount, Account>();

builder.Services.AddDbContext<KinoDbContext>(option =>
                option.UseNpgsql(builder.Configuration.GetConnectionString("KinoConnectionString")));

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