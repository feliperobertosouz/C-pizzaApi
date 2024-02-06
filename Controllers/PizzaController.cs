using PizzaAPI.Models;
using PizzaAPI.Services;
using Microsoft.AspNetCore.Mvc;
using PizzaAPI.Repositories;

namespace PizzaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase{

    private readonly IPizzaRepository _pizzaRepository;
    private readonly IIngredientRepository _ingredientRepository;
    public PizzaController(IPizzaRepository pizzaRepository, IIngredientRepository ingredientRepository){
        _pizzaRepository = pizzaRepository;
        _ingredientRepository = ingredientRepository;

    }

    [HttpPost]
    public IActionResult Add([FromBody]Pizza pizza){
        _pizzaRepository.Add(pizza);
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id){
        var pizza = _pizzaRepository.Get(id);
        var ingredients = pizza.ingredientsIds.Select(id => _ingredientRepository.Get(id)).ToList();
        return Ok(ingredients);
    }

    [HttpGet]
    public ActionResult<List<Pizza>> getAll(){
        var pizzas = _pizzaRepository.GetAll();
        return Ok(pizzas);
    } 


    public IActionResult Create(Pizza pizza){
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Create), new {id = pizza.Id}, pizza);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza){

        if( id != pizza.Id){
            return BadRequest();
        }

        var existingPizza = PizzaService.Get(id);
        if(existingPizza is null){
            return NotFound();
        }

        PizzaService.Update(pizza);
        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id){
        var pizza = PizzaService.Get(id);
        if (pizza is null)
            return NotFound();
        return NoContent();
    }
}