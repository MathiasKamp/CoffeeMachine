namespace CoffeeMachine
{
    public class TeamMaker : IBeverageMaker

    {
        private Recipe _recipe;

        public TeamMaker()
        {
            _recipe = new TeaRecipe(new Ingredients.Ingredients(0, 0.4, 0, 0));
        }

        public Beverage MakeBeverage()
        {
            foreach (var step in _recipe.Steps)
            {
                step.Execute();
            }

            return new Tea();
        }

        public Ingredients.Ingredients GetIngredientsForAnUnit()
        {
            return _recipe.Ingredients;
        }

        public bool CanMake(Ingredients.Ingredients ingredients)
        {
            return ingredients.GreaterThan(GetIngredientsForAnUnit());
        }
    }
}