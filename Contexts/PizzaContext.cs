using Microsoft.EntityFrameworkCore;
using PizzaAPI.Models;

public class PizzaContext : DbContext{

    public DbSet<Pizza> Pizzas {get; set;}
    public DbSet<Ingredient> Ingredients {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=pizza.db");
    }
}   