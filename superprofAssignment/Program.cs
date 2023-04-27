namespace superprofAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            while(true) {

                Console.WriteLine("1.Enter a new recipe ");

                Console.WriteLine("2.Scale recipe");

                Console.WriteLine("3.Reset quantities");

                Console.WriteLine("4.Display recipe");

                Console.WriteLine("5.Clear recipe");

                Console.WriteLine("6.Exit");


                Console.WriteLine("Select an option");
                string option=Console.ReadLine();

                Console.WriteLine();

                switch (option)
                {

                    case "1":
                        
                        recipe.ClearRecipe();

                        Console.WriteLine("Enter the number of ingredients");
                        recipe.numOfIngredients=Convert.ToInt32(Console.ReadLine());
                        for(int i=0;i<recipe.numOfIngredients;i++)
                        {

                            Console.WriteLine("Enter an ingredient name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter an ingredient quantity");
                            double quantity=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter an ingredient unit of measurement");
                            string uom=Console.ReadLine();
                            
                            recipe.AddIngredient(name, quantity, uom);

                        }

                        Console.WriteLine("Enter the number of steps");
                        recipe.numOfSteps=Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < recipe.numOfSteps; i++)
                        {
                            Console.WriteLine("Enter step");
                            string step=Console.ReadLine();

                            recipe.AddStep(step);

                        }
                        

                        break;

                    case "2":

                        Console.WriteLine("Enter a scale factor \n1) 0.5 \n2) 2 \n3) 3");
                        double scale = Convert.ToDouble(Console.ReadLine());
                        
                        recipe.ScaleRecipe(scale);

                        Console.WriteLine($"Recipe scaled by a factor of {scale}");

                        break;
                       case "3":
                        break;

                        case "4":
                        recipe.DisplayRecipe();
                        break;
                }


            }


        }
    }
}