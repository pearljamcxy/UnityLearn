using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StarCafe
{
    public class DexManager
    {
        public static DexManager Instance { get; private set; } = new DexManager();
        public readonly Dictionary<int, MonsterData> MonsterDict = new();


        public void LoadAllMonsters()
        {
            MonsterData FireSpirit = new MonsterData()
            {
                MonsterID = 1001,
                Name = "FireSpirit",
                Element = "fire",
                BaseAttack = 50,
                IsBoss = false
            };

            MonsterData IceSpirit = new MonsterData()
            {
                MonsterID = 1002,
                Name = "IceSpirit",
                Element = "ice",
                BaseAttack = 35,
                IsBoss = false
            };

            MonsterData DarkSpirit = new MonsterData()
            {
                MonsterID = 1003,
                Name = "DarkSpirit",
                Element = "foggy",
                BaseAttack = 100,
                IsBoss = true
            };
            MonsterDict[FireSpirit.MonsterID] = FireSpirit;
            MonsterDict[IceSpirit.MonsterID] = IceSpirit;
            MonsterDict[DarkSpirit.MonsterID] = DarkSpirit;
        }
    }
}
