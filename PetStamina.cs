using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 属性是唯一的通道，字段是真正的仓库： 以后无论你是吃药回血，还是挨打掉血，只要你给 CurrentStamina 赋值，经过 set 里的重重安检后，最终的值都会更新并存在私有的 _currentStamina 里面。
    /// </summary>
    internal class PetStamina
    {
        public int MaxStamina { get; }
        private int _currentStamina;

        public int CurrentStamina
        {
            get => _currentStamina;
            set => _currentStamina = Math.Max(0, Math.Min(value, MaxStamina));
        }

        //体力上限 (MaxStamina) 构造函数初始化宠物
        public PetStamina(int stamina)
        {
            MaxStamina = stamina;
            CurrentStamina = stamina;
        }

        public bool IsExhausted => _currentStamina == 0; 

    }
}
