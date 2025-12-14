using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dish
    {
        public string Name;
        public int Price;
        public double CookTime;

        //构造函数
        public Dish(string name, int price, double cooktime)
        {
            Name = name;
            Price = price;
            CookTime = cooktime;
            DateTime BrokenTime = DateTime.Now.AddMinutes(2);


            Console.WriteLine($"You have cooked dish{Name}");
        }


    }
}
