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





        }


    }

}
