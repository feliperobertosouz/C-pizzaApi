using PizzaAPI.Models;

namespace PizzaAPI.Repositories;

public interface IIngredientRepository{
    void Add(Ingredient ingredient);

    List<Ingredient> GetAll();

    Ingredient Get(int id);
}