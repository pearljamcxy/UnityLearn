using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CookGame
    {
        Dish burgerKing = new Dish(
                "BurgerKing", 400, 10, 10,
                new List<Ingredient>
                {
                    Ingredient.Bread,
                    Ingredient.Bacon,
                    Ingredient.Beef,
                    Ingredient.Cheese,
                    Ingredient.Carrot,
                    Ingredient.Lettuce
                }
             );

        Dish baconCheeseBurger = new Dish(
            "BaconCheeseBurger",
            250,
            7,
            10,
            new List<Ingredient>
            {
                    Ingredient.Cheese,
                    Ingredient.Bread,
                    Ingredient.Bacon,
            }
         );

        Dish veggieBurger = new Dish(
            "VeggieBurger",
            200,
            5,
            10,
            new List<Ingredient>
            {
                    Ingredient.Bread,
                    Ingredient.Lettuce,
                    Ingredient.Carrot,
                    Ingredient.Cheese
            }
         );

        Player player = new Player();

        public void start()
        {
            Console.WriteLine("GAME START!!");

            bool runnning = true;
            while ( runnning ) {
                Console.WriteLine("GAME START!!");
                Console.WriteLine("=======Choose what you want to do========");
                Console.WriteLine("1. Show your bag");
                Console.WriteLine("2. Show the ingredients in the kitchen:");
                Console.WriteLine("3. Buy the ingredient you choose");
                Console.WriteLine("4. Show dish menu");
                Console.WriteLine("5. Cook the dish and sell");
                
                Console.ReadKey();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        player.PlayerInfo();
                        break;

                    case "2":
                        Kitchen.IngredientPrices.ShowIngredientPrices();
                        break;







                }
                
            }


    }
}
