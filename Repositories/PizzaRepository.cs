using PizzaAPI.Models;

namespace PizzaAPI.Repositories;

public class PizzaRepository : IPizzaRepository
{
    private readonly PizzaContext _context = new PizzaContext();
    
    public void Add(Pizza pizza)
    {
        _context.Pizzas.Add(pizza);
        _context.SaveChanges();
    }

    public Pizza Get(int id)
    {
        return _context.Pizzas.Find(id);

    }

    public List<Pizza> GetAll()
    {
        return _context.Pizzas.ToList();

    }
}