using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_3
    {
        static void Main1(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input > 89) 
            {
                Console.Write('A');
            }
            else 
            {
                if (input > 79)
                {
                    Console.Write('B');
                }
                else
                {
                    if(input > 69)
                    {
                        Console.Write('C');
                    }
                    else
                    {
                        if (input > 59)
                        {
                            Console.Write('D');
                        }
                        else
                        {
                            Console.Write('F');
                        }
                    }
                }
            }
        }
    }
}
