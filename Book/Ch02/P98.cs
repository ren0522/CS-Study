﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P98
    {
        static void Main1(string[] args)
        {
            // 변수를 선언합니다.
            int _int = 273;
            long _long = 522731033865;
            float _flaot = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";

            //출력합니다.
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_flaot.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());



        }
    }
}
