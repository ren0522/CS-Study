﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class P179
    {
        static void Main1(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) 
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
