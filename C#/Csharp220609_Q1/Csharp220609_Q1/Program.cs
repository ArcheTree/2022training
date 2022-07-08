using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp220609_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1번 문제(자기소개서) ");
            Console.WriteLine("당신의 나이는?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("당신의 혈액형는?");
            string blood = Console.ReadLine();
            Console.WriteLine("당신의 MBTI는?");
            string mymbti = Console.ReadLine();

            Console.WriteLine("자기 소개서");
            Console.WriteLine("나이: "+age+"\n"+ "혈액형: " + blood + "\n" + "MBTI: " + mymbti + "\n" + "이름은 몰라도 감사합니다.");
            //           Console.WriteLine("혈액형: "+blood);
            //           Console.WriteLine("MBTI: "+mymbti);
            //           Console.WriteLine("이름은 몰라도 감사합니다.");
            Console.WriteLine(String.Format("나이:{0}, 혈액형: {1}, MBTI: {2}", age,blood,mymbti));
            Console.WriteLine($"나이:{age}, 혈액형:{blood}, MBTI:{mymbti}");

            Console.WriteLine("2번 문제 (너비, 높이 입력받아 사각형 넓이 구하기");
            
            Console.Write("너비값은? : ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("높이값은? : ");
            int high = int.Parse(Console.ReadLine());
            Console.WriteLine("넓이 값 = "+(row*high));

            Console.WriteLine("3번 문제(피타고라스 정리");

            Console.Write("가로 - ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("세로 - ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("결과 = "+((width*width)+(height*height)));

        }
    }
}
