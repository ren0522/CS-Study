using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2
{
    internal class _2_01
    {
        static void Main1(string[] args)
        {
            char[] str = { 'I', ' ', 'L', 'O', 'V', 'E', ' ', 'Y', 'O', 'U' };
            int row, co1;

            for (row = 1; row < 10; row++)
            {
                for (co1 = 0; co1 <= row; co1++)
                {
                    Console.Write(str[co1]);
                }
                Console.Write('\n');
            }
        }
    }
}
