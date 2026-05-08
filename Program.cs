using Microsoft.EntityFrameworkCore;
using lab1projekt.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<RestaurantDbContext>(options =>
    options.UseSqlServer("Server=localhost;Database=RestaurantDb;Trusted_Connection=True;TrustServerCertificate=True;"));

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();