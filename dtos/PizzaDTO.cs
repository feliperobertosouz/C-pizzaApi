public class PizzaRequestDto
{
    public string Name { get; set; }
    public bool IsGlutenFree { get; set; }
    public List<int> IngredientIds { get; set; }
    // Adicione mais propriedades conforme necessário


    public PizzaRequestDto(string name, bool isGlutenFree, List<int> ingredientsId){
        this.Name = name;
        this.IsGlutenFree = isGlutenFree;
        this.IngredientIds = ingredientsId;
    }
}