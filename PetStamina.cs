using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
