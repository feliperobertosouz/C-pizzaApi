using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI.Models;

[Table("Pizzas")]
public class Pizza{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}
    public string? Name {get; set;}
    public bool isGlutenFree {get;set;}

    // public List<Ingredient> ingredients {get;} = [];
    public List<int> ingredientsIds {get;set;} = new List<int>();
    
    public Pizza()
    {
        // Construtor padrão sem parâmetros
    }
    public Pizza(string name, bool isGlutenFree, List<int> ingredientsId){
        Name = name;
        this.isGlutenFree = isGlutenFree;
        this.ingredientsIds = ingredientsId;
    }
}