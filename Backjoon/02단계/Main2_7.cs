using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_7
    {
        static void Main1(string[] args)
        {
            string[] time = Console.ReadLine().Split();
            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);
            int c = int.Parse(Console.ReadLine());

            m += c;

            while (m >=60 )
            {
                h++;
                m -= 60;
            }
            if (h >= 24)
            {
                h-=24;
            }
            Console.WriteLine("{0} {1}", h, m);
        }
    }
}
