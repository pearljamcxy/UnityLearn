using System;

namespace ConsoleApp1
{
    class Practice
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=====choose your practice=======!!");

            // FarmGame game = new FarmGame();  // 创建实例
            // game.Start();                    // 调用实例方法

            // SlimeGauntletTest.MainTest2();

            Planet earth = new Planet("Earth", 2.0);
            for (int i = 0; i < 10; i++)
            {
                earth.Tick(1.0);
                Console.WriteLine($"Time {i+1}s ----- Energy:{earth.Energy}");
            }
        }
    }
}
