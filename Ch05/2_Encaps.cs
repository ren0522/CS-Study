﻿using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/08
 * 이름 : 김재원
 * 내용 : 캡슐화 실습하기 교재 p203
 * 
 * 캡슐화(encapsulation)
 *  - 캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보를 은닉하는 특성을 말한다.
 *  - 캡슐화를 위한 접근 제한자 public, private, protected를 제공한다.
 *  은닉된 정보의 안전한 제공을 위해 Getter와 Setter를 제공한다.(프로퍼티)
 * 
 */
namespace Ch05
{
    internal class _2_Encaps
    {
        static void Main1(string[] args)
        {

            //객체 생성과 초기화(생성자 호출)
            Account kb = new Account("국민은행", "110-11-1234", "김유신", 1000);
           
            kb.Deposit(4000);
            kb.Withdraw(3000);

            //취약코드
            //kb.balance--;
            //kb.balance += 10;

            kb.Show();

            //Car 객체 생성과 초기화
            Car sonata = new Car("소나타", "흰색",0);
            Car bmw = new Car("bmw", "초록색", 0);
            Car benz = new Car("벤츠", "검정색", 0);
            // setter 실행
            sonata.Name = "EF소나타";
            sonata.Speed = 0;

            // getter 실행
            Console.WriteLine("sonata 객체 name : "+sonata.Name);

            sonata.SpeedUp(60);
            sonata.Show();

            bmw.SpeedUp(50);
            bmw.Show();

            benz.SpeedUp(30);
            benz.Show();


        }






    }
}
