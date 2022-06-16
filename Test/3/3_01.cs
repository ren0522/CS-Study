using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    internal class _3_01
    {
        private string name;
        private int age;

        public _3_01(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void show()
        {
            Console.WriteLine("===============");
            Console.WriteLine("이름 : " + this.name);
            Console.WriteLine("나이 : " + this.age);
            Console.WriteLine("---------------");
        }

        static void Main1(string[] args)
        {
            _3_01 kim = new("김유신", 23);
            _3_01 lee = new("이순신", 31);

            kim.show();
            lee.show();
        }
    }
}
