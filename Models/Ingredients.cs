using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI.Models;

[Table("Ingredients")]
public class Ingredient{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}
    public string? Name {get;set;}
    public bool isVegan {get;set;}
    

    public Ingredient(string name, bool isVegan){
        Name = name;
        this.isVegan = isVegan;
    }
}