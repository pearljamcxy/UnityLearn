using System;

namespace ConsoleApp1
{
    class Practice
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=====choose your practice=======!!");

            FarmGame game = new FarmGame();  // 创建实例
            game.Start();                    // 调用实例方法

            // SlimeGauntletTest.MainTest2();
            // SlimeGauntletTest3.MainTest3();
        }
    }
}
