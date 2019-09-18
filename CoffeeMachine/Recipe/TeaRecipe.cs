namespace CoffeeMachine
{
    public class TeaRecipe:Recipe
    {
        public TeaRecipe(Ingredients.Ingredients ingredients) : base(ingredients)
        {
            Steps.Add(new PourWaterStep(ingredients.Water));
        }
    }
}