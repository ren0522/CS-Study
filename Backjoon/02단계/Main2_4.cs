using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_4
    {
        static void Main1(string[] args)
        {
            string input = (Console.ReadLine());
            int number = int.Parse(input);

            if (number % 4 == 0)
            {
                if(number % 400 ==0 )
                {
                    Console.WriteLine(1);
                }
                else if(number % 100 != 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }

            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
