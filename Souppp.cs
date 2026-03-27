using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Souppp
    {
        //定义世界法则 (写三个 Enum)
        public enum FoodType
        {
            Soup = 1,
            Stew = 2,
            Gumbo = 3
        }

        public enum Ingredient
        {
            Mushroom = 1,
            Chicken = 2,
            Carrot = 3,
            Potato = 4
        }

        public enum Seasoning
        {
            Spicy = 1,
            Salty = 2 ,
            Sweet = 3
        }
        // =======================================================
        // 零件 1：【防乱按雷达】并且显示给玩家的菜单 (只负责拦截乱敲，返回安全的数字)
        // =======================================================
        private int MakeSureNum()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result) && result >= 1 && result <= 4)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("请输入正确的编号！！");
                }
            }
        }
        // =======================================================
        // 零件 2：【后厨熬汤机】 (核心！完美演示：返回元组的方法)
        // =======================================================
        // 注意看这里的签名：机器启动不需要参数 ()，但干完活会吐出一个大元组！
        public (FoodType Name, Ingredient Main, Seasoning Spice) Cooksoup()
        {
            Console.WriteLine($"请选择你要的食物类型：\n1.{FoodType.Soup}\n2.{FoodType.Stew}\n3.{FoodType.Gumbo}!!");
            int food = MakeSureNum();
            Console.WriteLine($"请选择你要的主要食材：\n1.{Ingredient.Mushroom}\n2.{Ingredient.Chicken}\n3.{Ingredient.Carrot}\n4.{Ingredient.Potato}!!");
            int ingredientInput = MakeSureNum();
            Console.WriteLine($"请选择你要的调味料：\n1.{Seasoning.Spicy}\n2.{Seasoning.Salty}\n3.{Seasoning.Sweet}!!");
            int seasoningInput = MakeSureNum();

            return ((FoodType)food, (Ingredient)ingredientInput, (Seasoning)seasoningInput);
        }
        // =======================================================
        // 最终呈现：【前台服务员】 (游戏的主循环)
        // =======================================================


        public void SoupDone()
        {
            Console.WriteLine("===== 欢迎来到女巫的熬汤工坊 =====");
            while (true)
            {
                var soup = Cooksoup();
                Console.WriteLine($"你的{soup.Spice}{soup.Main}{soup.Name}做好了！！");

            }
        }

    }
}
