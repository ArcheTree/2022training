using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStudy08
{
    public class Human
    {
        public int age { get; set; }
        public string name { get; set; }

        public Human()
        {
            Console.WriteLine("인간 생성");
        }
        public Human(int age)
        {
            this.age = age;
            Console.WriteLine(age+"인간 생성!~!");
        }

        public void sleep()
        {
            Console.WriteLine("잠이 듭니다.");
            Console.WriteLine(name+"님이 잠들었습니다.");
            Console.WriteLine(age+"살 다운 잠자리입니다.");
        }

    }
}
