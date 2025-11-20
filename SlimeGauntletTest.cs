using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class SlimeGauntletTest
    {
        enum PlayerState {Idel, Attacking};
        static int[] EnemyHP = new int[] { 12, 24, 33, 10 };
        static List<int> bag = new List<int>() {10, 10, 5};
        static Random FightLevel = new Random();

        public static void MainTest2()
        {
            Console.WriteLine("Welcome to the Pokémon Trials!Good Luck!");
            bool PlayAgain;
            do
            {
                Rungame();
                PlayAgain = AskYesNO("Play agin??(Y/N): ");
            } while (PlayAgain);
            Console.WriteLine("Thanks for playing");
        }

        static void Rungame() {
            int playerHP = 20;
            PlayerState state = PlayerState.Idel;
            Console.WriteLine($"Enemy's HP:[{string.Join(",", EnemyHP)}]");
            Console.WriteLine($"you have potions:[{string.Join(",",bag)}]");

            for (int idx = 0; idx < EnemyHP.Length; idx++) 
            {
                Console.WriteLine($"The NO.{idx+1} slime is showing up!!");
                Console.WriteLine($"YOUR HP = {playerHP}, SLIME HP = {EnemyHP[idx]}");
                int slimeHP = EnemyHP[idx];

                while (playerHP>0 && slimeHP > 0)
                {
                    Console.WriteLine("Its your Turn!![A]Attacking! [D]Drink Potion [S]Skipping");
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.A)
                    {
                        state = PlayerState.Attacking;
                        int PlayerDmg = FightLevel.Next(7,15);
                        slimeHP = Math.Max(slimeHP - PlayerDmg, 0);
                        Console.WriteLine($"you give slime a {PlayerDmg} damage punch; it has {slimeHP}HP left");
                    }
                    else if (key == ConsoleKey.D)
                    {
                        state = PlayerState.Idel;
                        if (bag.Count > 0)
                        {
                            int heal = bag[0];
                            playerHP = playerHP + heal;
                            bag.RemoveAt(0);
                            Console.WriteLine($"you recoverd {heal} HP, you have {playerHP} now");
                        }
                        else
                        {
                            Console.WriteLine("you are running out of potions!");
                        }
                    }
                    else
                    {
                        state = PlayerState.Idel;
                        Console.WriteLine("you skipped!the slime is comming!");                   
                    }
                    // enermy's actions based on players state and potion drops
                    int enemyDmg = (state == PlayerState.Idel ? FightLevel.Next(1,5) : FightLevel.Next(2,8));
                    playerHP = Math.Max(0, playerHP - enemyDmg);
                    Console.WriteLine($"you got {enemyDmg} damage; you have {playerHP} left ><");
                }
                if (playerHP <= 0)
                {
                    Console.WriteLine("=========OHHH you died,game over TT============");
                    return;
                }
                Console.WriteLine($"the NO.{idx+1} Slime has been killed, good job!");
                if (FightLevel.NextDouble() > 0.3 )
                {   
                    int newPotion = FightLevel.Next(5, 10);
                    bag.Add(newPotion);
                    Console.WriteLine($"LUCKYYY! Found a {newPotion} HP potion ");
                }
            }
            Console.WriteLine("··········Victory! You’ve conquered the gauntlet!············");

        }

        //在 C#（以及大多数语言）里，定义方法时必须明确它返回的值的类型
        static bool AskYesNO(string prompt)
        {
            Console.WriteLine(prompt);
            ConsoleKey key;
            do
            {
                //因为 Console.ReadKey(true) 返回的不是按键值，而是一个 ConsoleKeyInfo 结构体你要从这个结构体中提取 Key 属性才得到按下的键。
                key = Console.ReadKey(true).Key; 
            } while (key != ConsoleKey.Y && key != ConsoleKey.N);
            Console.WriteLine(key == ConsoleKey.Y? "Y":"N");
            return key == ConsoleKey.Y;
        }



    }






}