using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POEPART1DARSHANCHETTY
{
    internal class Recipe
    {
        private int numIngredients;  //Creating a private variable to store the data securely and not allow for the user to change it unless given access to
        private string[] Ingredients;   //Creating a private array to store the data securely and not allow for the user to change it unless given access too
        private double[] ingredientQuantity;   //Creating a private array to store the data securely and not allow for the user to change it unless given access too
        private string[] ingredientUnit;   //Creating a private array to store the data securely and not allow for the user to change it unless given access too
        private string[] stepDescrip;   //Creating a private array to store the data securely and not allow for the user to change it unless given access too
        private int numStep;   //Creating a private variable to store the data securely and not allow for the user to change it unless given access too
        public static double scaler;
        public int[] original;




        public void RecipeDetails()  //Creating a seperate void for the details of the recipe for the user to provide the neccesary information
        {
            Console.WriteLine("Please enter the number of ingredients needed in the recipe: ");
            numIngredients = int.Parse(Console.ReadLine());  //Converting the stored data to an integer as "Console.WriteLine() stores it as a string

            Ingredients = new string[numIngredients];  //Storing the received data into the suitable array
            ingredientQuantity = new double[numIngredients];  //Storing the received data into the suitable array
            ingredientUnit = new string[numIngredients];  //Storing the received data into the suitable array

            for (int i = 0; i < numIngredients; i++)  //Creating a loop to allow the user to name each ingredient and quantity/measurement
            {
                Console.WriteLine($"Please enter the name of ingredient {i + 1} :");

                Ingredients[i] = Console.ReadLine();  //Storing the data into the corressponding array

                Console.WriteLine($"Please enter the quantity of {Ingredients[i]} :");

                ingredientQuantity[i] = int.Parse(Console.ReadLine());  //Storing the data into the corressponding array

                Console.WriteLine($"Please enter the unit of measurement for- ({ingredientQuantity[i]}) :");
                ingredientUnit[i] = Console.ReadLine();  //Storing the data into the corressponding array

            }

            Console.WriteLine("Please enter the number of steps: ");
            numStep = int.Parse(Console.ReadLine());  //Converting the stored data to an integer as "Console.WriteLine() stores it as a string
            stepDescrip = new string[numStep];   //Storing the data into the corressponding array


            for (int i = 0; i < numStep; i++)  //Creating a loop to allow the user to describe each step depending on the amount 
            {
                Console.WriteLine($"Please enter the description for step {i + 1}:");
                stepDescrip[i] = Console.ReadLine();  //Storing the data into the corressponding array

            }

            Console.WriteLine("Your recipe has been stored.");  //Allows the user to be notified that the recipe has been stored


        }

        public void DisplayRecipe()   //Creating a seperate void for the display option for the user to display the recipe
        {
            Console.WriteLine("Recipe~");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Ingredients:");
            for (int i = 0; i < numIngredients; i++)  //Creating a loop to display each ingredient, quantity and unit of measurment, depending on how much the user has entered
            {
                Console.WriteLine($"{ingredientQuantity[i]} {ingredientUnit[i]} {Ingredients[i]}");
            }

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Steps:");
            for (int i = 0; i < numStep; i++)  //Creating a loop to display each neccesary step description as per the amount of steps
            {

                Console.WriteLine($"Step {i + 1}. {stepDescrip[i]}");

            }

        }

        public void Scale(double scaler)
        {

            for (int i = 0; i < numIngredients; i++)
            {
                ingredientQuantity[i] *= scaler;
            }
        }

        public void ResetQuantity(double scaler)
        {
            for (int i = 0; i < numIngredients; i++)
            {
                ingredientQuantity[i] /= scaler;



            }

        }
        public void Clear()
        {
            Ingredients = null;
            ingredientQuantity = null;
            ingredientUnit = null;
            stepDescrip = null;
            numStep = 0;
        }
    }



}