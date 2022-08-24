using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStudy08
{
    public class Student : Human
    {

        public int score { get; set; }


        public void Study(int hour)
        {
            Console.WriteLine($"{score}점을 받았다");
            Console.WriteLine($"총 공부시간은 {hour}입니다.");
        }
    }
}
