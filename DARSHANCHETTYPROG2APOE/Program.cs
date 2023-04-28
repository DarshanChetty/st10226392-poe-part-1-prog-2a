using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPART1DARSHANCHETTY
{
    internal class Program : Recipe
    {
        //double scaler;
        static void Main(string[] args)
        {
            Recipe rec = new Recipe();

            while (true)
            {
                Console.WriteLine("-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -");

                Console.WriteLine("Please select one of the following: \n");

                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset Quantities");
                Console.WriteLine("5. Clear Recipe");
                Console.WriteLine("6. Exit \n");

                Console.WriteLine("-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -");
                Console.WriteLine("Enter your Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        rec.RecipeDetails();
                        break;

                    case 2:
                        rec.DisplayRecipe();
                        break;

                    case 3:
                        Console.WriteLine("Please enter the scaling factor: ");
                        scaler = double.Parse(Console.ReadLine());

                        rec.Scale(scaler);
                        break;

                    case 4:
                        rec.ResetQuantity(scaler);
                        break;

                    case 5:
                        rec.Clear();
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;




                }
            }


        }
    }
}

