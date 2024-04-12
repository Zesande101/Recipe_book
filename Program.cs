namespace Recipe_book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            while (true)
            {
                Console.WriteLine("RECIPE BOOK APPLICATION");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Press 1, to add recipe: ");
                Console.WriteLine("Press 2, to display recipes: ");
                Console.WriteLine("Press 3, to scale recipes: ");
                Console.WriteLine("Press 4, to reset quantities");
                Console.WriteLine("Press 5, to clear recipes");
                Console.WriteLine("Press 6, to exit app");
                Console.WriteLine("-----------------------------------");
                int menuAnswer = int.Parse(Console.ReadLine());

                switch (menuAnswer)
                {
                        case 1:
                            recipe.EnterRecipe();
                            break;

                        case 2:
                            recipe.DisplayRecipe();
                            break;

                        case 3:
                            Console.WriteLine("Enter a scale of 2, 3 or 0.5");
                            double scale2 = double.Parse(Console.ReadLine());
                            recipe.RecipeFractor(scale2);
                            break;
                        case 4:
                            recipe.ResetRecipe();
                            break;
                        case 5:
                            recipe.ClearRecipe();
                            break;
                        case 6:
                        Console.WriteLine("Please enter a value between 1 - 6");
                        break;
                }
               
            }

        }
    }           

class Recipe
{
    private String[] ingredients;
    private String[] steps;
    private String[] unit;
    private double[] quantity;
    public Recipe()
    {
        ingredients = new String[0];
        steps = new String[0];
        unit = new String[0];
        quantity = new double[0];
    }
    public void EnterRecipe()
    {
            Console.WriteLine("Enter the number of ingredients: ");
            int noIngredients = int.Parse(Console.ReadLine());

            ingredients = new string[noIngredients];
            steps = new String[noIngredients];  
            unit = new String[noIngredients];
            quantity = new double[noIngredients];

            for (int i = 0; i < noIngredients; i++)
            {
                Console.WriteLine("Enter the name of the ingredient: ");
                ingredients[i] = Console.ReadLine();

                Console.WriteLine("Enter the quantity of ingredient :  ");
                quantity[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the unit of measurement for :");
                unit[i] = Console.ReadLine();

            }
            Console.WriteLine("Enter the number of steps: ");
            int noSteps = int.Parse(Console.ReadLine());
            steps = new String[noSteps];

            for (int i = 0; i < noSteps; i++)
            {
                Console.WriteLine("Enter step {i+1} :");
                steps[i] = Console.ReadLine();
            }
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients: ");
            for(int i = 0;i < ingredients.Length;i++)
            {
                Console.WriteLine($"- {quantity[0]} {unit[0]} of {ingredients[0]}");
            }
            Console.WriteLine("Steps: ");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"-{steps[0]}");
            }
        }
        public void RecipeFractor(double scale)
        {
            for (int i = 0;i < quantity.Length; i++)
            {
                quantity[i] *= scale;
            }
        }
        public void ResetRecipe()
        {
            for(int i = 0;quantity.Length > 0; i++)
            {
                quantity[i] /= 2;
            }
        }
        public void ClearRecipe()
        {
            ingredients = new String[0];
            steps = new String[0];
            unit = new String[0];
            quantity = new double[0];

        }

    }
}


