using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main3_01
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            for (int n = 1; n <= 9; n++)
            {
                output = (input * n);
            }

            Console.WriteLine("{0} {*} {1} {=} {2}", input, output);

        }
    }
}
