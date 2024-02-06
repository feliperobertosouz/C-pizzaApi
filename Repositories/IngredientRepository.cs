using PizzaAPI.Models;

namespace PizzaAPI.Repositories;

public class ingredientRepository : IIngredientRepository{

    private readonly PizzaContext _context = new PizzaContext();

    public void Add(Ingredient ingredient)
    {
        _context.Ingredients.Add(ingredient);
        _context.SaveChanges();
    }

    public Ingredient Get(int id)
    {
        return _context.Ingredients.FirstOrDefault(i => i.Id == id);
    }

    public List<Ingredient> GetAll()
    {
        return _context.Ingredients.ToList();
    }


}