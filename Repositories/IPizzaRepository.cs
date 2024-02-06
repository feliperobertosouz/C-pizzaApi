using PizzaAPI.Models;

namespace PizzaAPI.Repositories;

public interface IPizzaRepository
{
    void Add(Pizza pizza);

    List<Pizza> GetAll();

    Pizza Get(int id);
}