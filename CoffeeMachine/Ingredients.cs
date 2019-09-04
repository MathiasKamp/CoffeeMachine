namespace CoffeeMachine
{
    public class Ingredients
    {
        public Ingredients(int coffeeBeans, double water, double milk, int chocolate)
        {
            CoffeeBeans = coffeeBeans;
            Water = water;
            Milk = milk;
            Chocolate = chocolate;
        }

        public int CoffeeBeans { get; set; } // remove setter so that the maker cant change the ingredeints/. encapsulation rule
        public double Water { get; set; }
        public double Milk { get; set; }
        public int Chocolate { get; set; }

        public bool GreaterThan(Ingredients recipeIngredients)
        {
            return Water>= recipeIngredients.Water && CoffeeBeans>= recipeIngredients.CoffeeBeans && Milk>= recipeIngredients.Milk && Chocolate>= recipeIngredients.Chocolate;
        }

        public void ReduceBy(Ingredients recipeIngredients)
        {
            Water -= recipeIngredients.Water;
            CoffeeBeans -= recipeIngredients.CoffeeBeans;
            Chocolate -= recipeIngredients.Chocolate;
            Milk -= recipeIngredients.Milk;
        }

        public bool isEqual(Ingredients remainingIngredients)
        {return Water == remainingIngredients.Water && CoffeeBeans == remainingIngredients.CoffeeBeans && Milk == remainingIngredients.Milk && Chocolate == remainingIngredients.Chocolate;
        }
    }
}