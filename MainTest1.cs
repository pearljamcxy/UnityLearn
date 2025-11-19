using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class SlimeGauntletTest1
    {
        enum PlayerState { Idle, Attacking }

        static List<int> bag = new List<int>() { 10 };   // 药水回复量
        static int[] enemyHP = new int[] { 5, 7, 6, 8 };  // 一排史莱姆的HP
        static Random rng = new Random();

        public static void MainTest1()
        {
            Console.WriteLine("=== Slime Gauntlet 史莱姆试炼 ===");
            bool playAgain;
            do
            {
                RunGame();
                playAgain = AskYesNo("再来一局吗？(Y/N): ");
            } while (playAgain);
            Console.WriteLine("Thanks for playing!");
        }

        static void RunGame()
        {
            int playerHP = 20;
            PlayerState state = PlayerState.Idle;

            // 展示敌人与背包（foreach + string.Join）
            Console.WriteLine($"敌人HP：[{string.Join(", ", enemyHP)}]");
            Console.WriteLine($"背包药水：{string.Join(", ", bag)}（每瓶回复上述数值）");

            // 逐个敌人（for）
            for (int idx = 0; idx < enemyHP.Length; idx++)
            {
                int eHP = enemyHP[idx];
                Console.WriteLine($"\n第 {idx + 1} 只史莱姆出现了！HP={eHP}");

                // 与单个敌人战斗（while）
                while (eHP > 0 && playerHP > 0)
                {
                    Console.WriteLine($"\n你的HP={playerHP} | 史莱姆HP={eHP}");
                    Console.Write("[A]攻击  [H]喝药水  [S]跳过一回合：");
                    var key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.A)
                    {
                        state = PlayerState.Attacking;
                        int dmg = rng.Next(3, 7); // 3~6
                        eHP = Math.Max(0, eHP - dmg);
                        Console.WriteLine($"你攻击造成 {dmg} 伤害，史莱姆剩余 {eHP}。");
                    }
                    else if (key == ConsoleKey.H)
                    {
                        if (bag.Count > 0)
                        {
                            int heal = bag[0];
                            bag.RemoveAt(0);
                            playerHP += heal;
                            Console.WriteLine($"喝下药水回复 {heal}，你的HP={playerHP}");
                        }
                        else Console.WriteLine("没有药水了！");
                        state = PlayerState.Idle;
                    }
                    else
                    {
                        Console.WriteLine("你选择观望，对方来了！");
                        state = PlayerState.Idle;
                    }

                    // 敌人行动（基于你的状态做点差异）
                    int enemyDmg = (state == PlayerState.Attacking) ? rng.Next(2, 6) : rng.Next(1, 4);
                    playerHP = Math.Max(0, playerHP - enemyDmg);
                    Console.WriteLine($"史莱姆反击造成 {enemyDmg} 伤害，你的HP={playerHP}");
                }

                if (playerHP <= 0)
                {
                    Console.WriteLine("\n你倒下了……试炼失败。");
                    return;
                }

                Console.WriteLine($"第 {idx + 1} 只史莱姆被击败！");
                // 小奖励：偶尔掉落药水（列表操作 + 条件）
                if (rng.NextDouble() < 0.5)
                {
                    bag.Add(10);
                    Console.WriteLine("掉落了一瓶 10 点回复药水，已放入背包。");
                }
            }

            Console.WriteLine("\n恭喜！你通过了史莱姆试炼！");
        }

        // 小函数：询问是否继续（do…while 保证至少询问一次）
        static bool AskYesNo(string prompt)
        {
            Console.Write(prompt);
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Y && key != ConsoleKey.N);

            Console.WriteLine(key == ConsoleKey.Y ? "Y" : "N");
            return key == ConsoleKey.Y;
        }
    }
}
