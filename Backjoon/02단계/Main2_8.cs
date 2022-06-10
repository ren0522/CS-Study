using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_8
    {
        static void Main1(string[] args)
        {
            string[] time = Console.ReadLine().Split(' ');
            int x = int.Parse(time[0]);
            int y = int.Parse(time[1]);
            int z = int.Parse(time[2]);

            int[] arr = {x,y,z};

            int maxNum = arr[0];

            for (int i = 0; i < 3; i++)
            {
                if (maxNum < arr[i])
                {
                    maxNum = arr[i];
                }
            }
            if (x == y)
            {
                if (y == z)
                {
                    int a = (10000+(y*1000));
                    Console.WriteLine(a);
                }
                else
                {
                    int b = (1000 + (x * 100));
                    Console.WriteLine(b);
                }
            }
            else if (y == z)
            {
                if (x == z)
                {
                    int c = (10000 + (x * 1000));
                    Console.WriteLine(c);
                }
                else
                {
                    int d = (1000 + (y * 100));
                    Console.WriteLine(d);
                }
            }
            else if (x == z)
            {
                if (y == z)
                {
                    int f = (10000 + (y * 1000));
                    Console.WriteLine(f);
                }
                else
                {
                    int e = (1000 + (x * 100));
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine(maxNum*100);
            }
        }
    }
}
