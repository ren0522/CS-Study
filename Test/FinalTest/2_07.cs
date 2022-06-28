﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/28
 * 이름 : 김재원
 * 내용 : [총정리 문제] 반복문 원주율 계산
 * 
 * 원주율 공식
 * 
 */
namespace Test.FinalTest
{
    internal class _2_07
    {
        static void Main1(string[] args)
        {
            bool sign = false;
            double pi = 0;

            for (int i =1; i <=10000; i +=2 )
            {
                if (sign == false)
                {
                    pi += 1.0 / i;
                    sign = true;
                }
                else
                {
                    pi -= 1.0 / i;
                    sign = false;
                }
                Console.WriteLine("i = {0}, pi = {1}", i, 4* pi);
            }
        }
    }
}
