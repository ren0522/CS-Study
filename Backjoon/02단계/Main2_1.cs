﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main2_1
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);

            if (n1 > n2)  Console.WriteLine(">");
            if (n1 < n2)  Console.WriteLine("<");
            if (n1 == n2)  Console.WriteLine("==");
        }
    }
}
