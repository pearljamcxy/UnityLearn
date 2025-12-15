using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1 { 
    //先把架构搭出来，再往里填东西
    //===== 材料定义 =====
    public enum Ingredient
    {
        Bread,
        Bacon,
        Beef,
        Cheese,
        Carrot,
        Lettuce

    }
    //===== 菜谱 =====
    public class Dish
    {
        internal string Name;
        internal int Price;
        internal int CookTime;
        internal int SpoilTime;
        //这个 List 里只能放 enum Ingredients 的值：
        //我有一个变量，名字叫 RequiredIngredients，它是一个装着 Ingredients（枚举）的 List。
        internal List<Ingredient> RequiredIngredients;

        internal Dish(string name,
            int price,
            int cookTime,
            int spoilTime,
            List<Ingredient> requiredIngredients)
        {
            Name = name;
            Price = price;
            CookTime = cookTime;
            SpoilTime = spoilTime;
            RequiredIngredients = requiredIngredients;
        }
     }

    // ===== 玩家 =====
    //凡是有状态、会变化、需要保存的东西，一律不能 static。static 和“状态”天生相斥。
    public class Player
    {
        public int Gold = 500;
        public Dictionary<Ingredient, int> Inventory = new Dictionary<Ingredient, int>();

        public void AddIngredient(Ingredient ingredient, int amount = 1)
        {
            if (!Inventory.ContainsKey(ingredient))
            {
                Inventory[ingredient] = 0;
            }
            Inventory[ingredient] += amount;
        }

        public void PlayerInfo()
        {
            Console.WriteLine("==========Player's Bag==========");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item.Key} x {item.Value}");
            }
            Console.WriteLine($"Gold:{Gold}");
            Console.WriteLine("================================");
        }
    }
    //===== 厨房 =====
    public class Kitchen 
    {
        public static bool CookDish(Player player, Dish dish)
            {
                //检查dish是不是在player的背包里
                foreach (var ingredient in dish.RequiredIngredients)
                {
                    if (!player.Inventory.ContainsKey(ingredient) || player.Inventory[ingredient] <= 0)
                    {
                        Console.WriteLine("there are not enough ingredients in bag");
                        return false;
                    }
                    
                }

                Console.WriteLine($"Start to cook {dish.Name}....");
                Thread.Sleep(1000 * dish.CookTime);

                //消耗材料
                foreach (var ingredient in dish.RequiredIngredients)
                {
                    player.Inventory[ingredient] = Math.Max(0, player.Inventory[ingredient] -1);
                    
                }

                //挣钱
                player.Gold += dish.Price;

                Console.WriteLine($"you cooked dish{dish.Name} and sold it; you have earn {dish.Price} gold");
                return true;

            }

    }

   
    
}
