﻿using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 * 날짜 : 2022/06/13
 * 이름 : 김재원
 * 내용 : 인터페이스 실습 교재 p425
 * 
 * 
 * 
 * 
 */
namespace Ch06
{
    internal class _2_Interface
    {
        static void Main(string[] args)
        {
            //인터페이스 공동 클래스 구조설계
            IRemoteControl lg = new LGremocon();
            IRemoteControl samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.ChDown();
            lg.SoundUp();
            lg.PowerOff();

            samsung.PowerOn();
            samsung.ChUp();
            samsung.SoundDown();
            samsung.PowerOff();

            //인터페이스를 활용한 다중 상속
            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();




        }

    }
}
