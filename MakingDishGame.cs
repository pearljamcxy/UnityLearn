using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static ConsoleApp1.MakingDishGame;

namespace ConsoleApp1
{
    internal class MakingDishGame
    {
        public enum Material
        {
            Bread,
            Bacon,
            Cheese,
            Tomato,
            Potato,
            Greenleafs
        }

        public static class MaterialPrice
        {
            public static Dictionary<Material, int> MaterialCost = new Dictionary<Material, int>()
            {
                {Material.Bread, 2},
                {Material.Bacon, 10},
                {Material.Cheese, 15},
                {Material.Tomato, 5},
                {Material.Potato, 4},
                {Material.Greenleafs, 8},
            };

            public static int GetPrice(Material material)
            {
                return MaterialCost[material];
            }

            public static void ShowMaterialCost()
            {
                Console.WriteLine("========Material Price Map==========");
                foreach (var item in MaterialCost)
                {
                    Console.WriteLine($"{item.Key}:{item.Value}");
                }    

            }
        }

        public class DishMaker
        {
            public string Name {  get;  }
            public int CookTime { get; }
            public int SpoilTime { get; }
            public List<Material> DishMaterial = new List<Material>();

            public DishMaker(string name, int cookTime, int spoilTime, List<Material> dishMaterial)
            {
                Name = name;
                CookTime = cookTime;
                SpoilTime = spoilTime;
                DishMaterial = dishMaterial;
            }

            public int Cost()
            {
                int total = 0;
                foreach (var item in DishMaterial)
                {
                   total += MaterialPrice.MaterialCost[item];
                }
                return total;
            }

            public int SellPrice()
            {
                return Cost() * 2;
            }
        }

        public class Player
        {
            public int Gold = 500;
            public Dictionary <Material, int> MaterialBag = new Dictionary<Material, int>();
            public Dictionary<DishMaker, int> DishBag = new Dictionary<DishMaker, int>();

            public int BuyMaterial(Material material, int amount)
            {
                Gold -= Math.Max(0, MaterialPrice.GetPrice(material) * amount);
                MaterialBag[material] = amount;
                Console.WriteLine($"you've bought {material} x {amount}!");
                return Gold;
            }

            public void ClearBag()
            {
                MaterialBag.Clear();
            }

            public void PlayerInfo()
            {
                Console.WriteLine($"you have {Gold} Gold");
                Console.WriteLine("========You Opened your bags!============");
                foreach (var pairs in MaterialBag)
                {
                    Console.WriteLine($"{pairs.Key} x {pairs.Value}");
                }
            }

            public void SellAllDish()
            {
                int totalSold = 0;
                foreach (var pair in DishBag)
                {
                    totalSold += pair.Key.SellPrice() * pair.Value;
                }
                Gold += totalSold;
                DishBag.Clear();

                Console.WriteLine($"You sold all dishes and earned {totalSold} gold!");
            }
        }
        
    }


}
