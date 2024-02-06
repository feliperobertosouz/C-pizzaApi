using Microsoft.AspNetCore.Mvc;
using PizzaAPI.Models;
using PizzaAPI.Repositories;

namespace PizzaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class IngredientController : ControllerBase{

    private readonly IIngredientRepository _ingredientRepository;

    public IngredientController(IIngredientRepository ingredientRepository){
        _ingredientRepository = ingredientRepository;
    }

    [HttpGet]
    public IActionResult GetAll(){
        var ingrents = _ingredientRepository.GetAll();
        return Ok(ingrents);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id){
        var ingredient = _ingredientRepository.Get(id);
        return Ok(ingredient);
    }

    [HttpPost]
    public IActionResult Add(Ingredient ingredient){
        _ingredientRepository.Add(ingredient);
        return Ok(ingredient);
    }
}