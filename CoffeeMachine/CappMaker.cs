namespace CoffeeMachine
{
    public class CappMaker : IBeverageMaker
    {
        private Recipe _recipe;

        public CappMaker()
        {
            _recipe = new CappRecipe( new Ingredients(12, 0.3, 0.1, 1));
        }

        public Beverage MakeBeverage()
        {
            foreach (var step in _recipe.Steps)
            {
                step.Execute();
            }
            return new Capp();
        }

        public Ingredients GetIngredientsForAnUnit()
        {
            return _recipe.Ingredients;
        }

        public bool CanMake(Ingredients ingredients)
        {
            return ingredients.GreaterThan(GetIngredientsForAnUnit());
        }
        
    }
}