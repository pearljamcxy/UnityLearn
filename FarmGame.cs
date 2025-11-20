using System;

namespace ConsoleApp1
{
    internal class FarmGame
    {
        private Crop crop = new Crop();

        public void Start()
        {
            Console.WriteLine("🌾 Welcome to the Mini Farm Test Program!");
            Console.WriteLine("Testing: daily growth, bug system, death, fertilizer, harvest.\n");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("1. Next day (GrowOneDay)");
                Console.WriteLine("2. Use Fertilizer");
                Console.WriteLine("3. Use BUG Dealer");
                Console.WriteLine("4. Harvest");
                Console.WriteLine("5. Show Your Crop's Status");
                Console.WriteLine("0. Exit");

                Console.Write("Your choice: ");
                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        crop.GrowOneDay();
                        break;

                    case "2":
                        crop.UseFertilizer();
                        break;

                    case "3":
                        crop.UseBugDealer();
                        break;

                    case "4":
                        crop.Harvest();
                        break;

                    case "5":
                        ShowStatus();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            }
        }

        private void ShowStatus()
        {
            Console.WriteLine("📋 Crop Status:");
            Console.WriteLine($"Growing day: {GetPrivateField("growingDay")}");
            Console.WriteLine($"Mature: {crop.IsMature}");
            Console.WriteLine($"Dead:   {crop.IsDead}");
            Console.WriteLine($"Has bug: {crop.hasBug}");
            Console.WriteLine($"Has fertilized: {crop.fertilizerApplied}");

        }

        // Helper: 反射读取 private growingday，仅用于测试
        private int GetPrivateField(string field)
        {
            var f = typeof(Crop).GetField(field,
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);

            return (int)f.GetValue(crop);
        }
    }
}
