using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vin_Fletcher_s_Arrow_Workshop
    {
        enum Arrowhead
        {
            Steel,
            Wood,
            Obsidian
        }
        enum Fletching
        {
            Plastic,
            TurkeyFeathers,
            GooseFeathers
        }

        class Arrow
        {
            // 字段：这支箭的客观属性
            private Arrowhead arrowhead;
            private Fletching fletching;
            private float length;

            public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
            {
                this.arrowhead = arrowhead;
                this.fletching = fletching;
                this.length = length;
            }

           public float GetCost()
            {
                float arrowCost = arrowhead switch
                {
                    Arrowhead.Steel => 10,
                    Arrowhead.Wood => 3,
                    Arrowhead.Obsidian => 5,
                    _ => 0,
                };

                float fletchCost = fletching switch
                {
                    Fletching.Plastic => 10,
                    Fletching.GooseFeathers => 3,
                    Fletching.TurkeyFeathers => 5,
                    _ => 0,
                };

                return arrowCost + fletchCost + (0.05f * length);
           }
        }
        public void Run()
        {
            // 🌟 抛弃所有前台交互，直接暴力 new 一个“木头+鹅毛+75厘米”的箭！
            Arrow testArrow = new Arrow(Arrowhead.Steel, Fletching.Plastic, 99f);

            // 直接看算钱的机器有没有出 Bug
            Console.WriteLine($"【硬核测试】这支箭的造价是: {testArrow.GetCost()}");
        }
    }
}
