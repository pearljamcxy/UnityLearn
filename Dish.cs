using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //先把架构搭出来，再往里填东西
    //===== 材料定义 =====
    enum Ingredient
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

    //===== 厨房 =====
    public static class Kitchen
    {

    }

    public static class Player
    {

    }
    
}
