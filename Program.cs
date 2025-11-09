using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a single line comments!
            /*
             * multi line comments!
             * i can write anything here!!
             * 
             */
            enum PlayerState
        {
            Idle,
            Attacking
        }


            int[] intArray = new int[] {1,2,3,4,5,6};

            List<int> intList = new List<int>() {0,0,3,4,5};

            intList.Add(intArray[5]);
            intList.Remove(4);
            foreach (int i in intArray) { Console.WriteLine(i); }
            for (int i = 0; i < intArray.Length; i++) { 
                Console.WriteLine(i+ " "+intArray[i]); 
            }

            int k = 0;
            while (k<5)
            {
                k++;
                Console.WriteLine(k + " " + intArray[k]);
            }

            int j = 0;
            do{
                j++; Console.WriteLine(j + " " + intArray[j]);
            } while (j<3);

            Console.WriteLine(string.Join("x", intArray));
            Console.WriteLine(string.Join("x", intList));
            Console.ReadKey(); // 防止窗口瞬间关闭
        }


        static void TestFunction() { }

        static bool SecondTestFunction(int k) { return k < 100; }


    }
}
