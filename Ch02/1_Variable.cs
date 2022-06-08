using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/02
 * 이름 : 김재원
 * 내용 : C# 변수 실습하기 교재
 * 
 * 변수(Variable)
 * -데이터를 처리하기위해 생성되는 메모리 공간
 * -여러번 데이터를 변경할 수 있음
 * 
 * 상수
 * -데이터를 변경할 수 없는 변수
 */

namespace Ch02
{
    internal class _1_Variable
    {
        static void Main1(string[] args)
        {
            /////////////////
            //변수
            /////////////////
            int num1; // 선언
            num1 = 1; // 대입

            int num2 = 2; //선언과 초기화
            int num3 = num1 + num2; //연산

            Console.WriteLine("num3 : "+num3); //결과확인




            /////////////////
            //상수
            /////////////////
            const double PI = 3.141592;
            const int NUM = 10;
            //num = 20;
            //num = 30;

            Console.WriteLine("num : "+NUM);
            Console.WriteLine("PI : "+PI);

        }

    }
}
