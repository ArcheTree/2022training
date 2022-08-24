using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStudy08
{
    public class Workder :Human
    {
        public Workder()
        {

        }

        //조상클래스에 생성자중에서 매개변수가 있는 생성자를 명시적으로 호출
        public Workder(int a) : base(a)
        {
            Console.WriteLine("나이: "+a);
        }


        public int pay { get; set; }

        public int work()
        {
            if (pay == 0) { Console.WriteLine("노동청가자 이세상에 공짜란 없다"); }
            else { Console.WriteLine(pay + "만큼만 일합니다."); }
            return pay *30;
        }
    }
}
