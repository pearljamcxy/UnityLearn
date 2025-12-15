using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Practice
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=====choose your practice=======!!");

            /*
            ==============================种田游戏入口=========================================
            FarmGame game = new FarmGame();  // 创建实例
            game.Start();                    // 调用实例方法
            */

            /*
            ==============================史莱姆游戏入口=========================================
            SlimeGauntletTest.MainTest2();
            */


            /* 
            ==============================星球游戏入口=========================================
            Planet earth = new Planet("Earth", 2.0);
            for (int i = 0; i < 10; i++)
            {
                earth.Tick(1.0);
                Console.WriteLine($"Time {i+1}s ----- Energy:{earth.Energy}");
            }
            */


            //==============================做饭游戏入口=========================================
            //定义三种dish
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

            // 创建玩家
            Player player = new Player();
            player.AddIngredient(Ingredient.Bread, 10);
            player.AddIngredient(Ingredient.Bacon, 12);
            player.AddIngredient(Ingredient.Beef, 10);
            player.AddIngredient(Ingredient.Cheese, 12);
            player.AddIngredient(Ingredient.Carrot, 11);
            player.AddIngredient(Ingredient.Lettuce, 11);

            player.PlayerInfo();

            // 做菜
            Kitchen.CookDish(player, burgerKing);
            Kitchen.CookDish(player, veggieBurger);
            Kitchen.CookDish(player, baconCheeseBurger);

            player.PlayerInfo();

            Console.WriteLine("游戏结束，按任意键退出");
            Console.ReadKey();


        }


    }

}
