using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superprofAssignment
{
    public class Recipe
    {
        public int numOfIngredients { get; set; }
        public List<Ingredient> Ingredients { get;set; }
        public int numOfSteps { get; set; } 
        public List<string> steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            steps= new List<string>();

        }

        public void AddIngredient(string name,double quantity,string uom)
        {
            Ingredients.Add(new Ingredient(name,quantity,uom));


        }

        public void AddStep(string step)
        {
            steps.Add(step);

        }

        public void ScaleRecipe(double scale)
        {
            foreach (var ingredient in Ingredients) { 
            
            ingredient.Quantity *= scale;
              
            } 

        }

        public void ClearRecipe()
        {

            numOfIngredients = 0;
            Ingredients.Clear();
            numOfSteps = 0;
            steps.Clear();

        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"ingredients({numOfIngredients}):");

            foreach (var ingredient in Ingredients)
            {

            Console.WriteLine($"{ingredient.Quantity}-{ingredient.UOM}-{ingredient.Name}");
            }
            Console.WriteLine($"\nSteps({numOfSteps}):");

            for(int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i+1}. {steps[i]}");
            }
        }

    }


}
