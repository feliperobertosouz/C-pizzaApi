using Microsoft.EntityFrameworkCore;
using PizzaAPI.Models;
using PizzaAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// var dbFilePath = "pizzas.db";
// Console.WriteLine($"dbFilePath: {dbFilePath}");
// builder.Services.AddDbContext<PizzaContext>(options => {
//     options.UseSqlite($"Data Source={dbFilePath}");
// });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IPizzaRepository, PizzaRepository>();
builder.Services.AddTransient<IIngredientRepository, ingredientRepository>();
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
