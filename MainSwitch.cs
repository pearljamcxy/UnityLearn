using ConsoleApp1.StarCafe;
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


            /*
            //==============================做饭游戏入口=========================================
            //定义三种dish
     

            // 创建玩家
            Player player = new Player();
            player.BuyIngredient(Ingredient.Bread, 10);
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
            */

            /*
            // ============================== 做汤游戏入口 =========================================
            Souppp game = new Souppp();  // 创建实例
            game.SoupDone();                    // 调用实例方法
            */

            /*
            // ============================== 造箭工厂入口 =========================================
            Vin_Fletcher_s_Arrow_Workshop arrow = new();
            arrow.Run();
            */

            // ============================== 属性精灵数据蓝图 =========================================
            DexManager.Instance.LoadAllMonsters();

            var data = DexManager.Instance.MonsterDict[1003];
            Console.WriteLine($"这是{data.Name},{data.Element}属性,基础攻击力为{data.BaseAttack}");
            if (data.IsBoss)
            {
                Console.WriteLine("它是Boss！！注意！");
            }
            else
            {
                Console.WriteLine("你得到了新的伙伴！");
            }
        }


    }

}
