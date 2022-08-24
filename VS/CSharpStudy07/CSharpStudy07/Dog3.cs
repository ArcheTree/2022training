using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07
{
    public partial class Dog
    {
        public void bark()
        {
            Console.WriteLine(name+"이 주인을 찾습니다.");
        }

        public void sleep()
        {
            Console.WriteLine("코드명이 "+code + "인 강아지 "+name+"이/가 잠을 잡니다.");
        }
    }
}
