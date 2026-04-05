using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable] //请把这个类的内容在编辑器界面上展示给我看。请允许我把这个类的实例保存成文件(存档)

    public class MonsterData
    {
        public int MonsterID;
        public string Name;
        public string Element;
        public float BaseAttack;
        public bool IsBoss;
    }
}
