using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_5
    {
        static void Main1(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());  

            if(x > 0 && y > 0)
            {
                Console.WriteLine(1);
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine(2);
            }
            if (y < 0 && x > 0)
            {
                Console.WriteLine(4);
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
            }
        }
    }
}
