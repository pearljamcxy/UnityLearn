using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    // 定义星球类
    internal class Planet
    {
        public string Name;
        public string Description;
        public double Energy;
        public double EnergyAcSpeed;
        
        public Planet(string name, double acspeed)
        {
            Name = name;
            Description = "This is a new planet";
            Console.WriteLine(Description);
            Energy = 0;
            EnergyAcSpeed = acspeed;

        }

        //deltatime = 当前时间 -上一帧时间
        public void Tick(double deltaTime)
        {
            Energy += deltaTime * EnergyAcSpeed;
        }

    }
   
}
