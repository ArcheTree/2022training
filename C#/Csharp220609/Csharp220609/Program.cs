using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp220609
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm Under Dog");
            Console.WriteLine("So. Real Under Dog is Nohtingham"+"\n");
            Console.WriteLine("i'm Nohtingham");
            Console.WriteLine("안녕" + "하세요");
            Console.WriteLine(1 + 2 + 3 + " " + 4 + 5);

            //XOR -> 베타적 or = 조건전부 true, false의 경우 무조건 false( 아이콘 ^)

            Console.WriteLine(true&true);
            Console.WriteLine(true|false);
            Console.WriteLine(true^true);   
            Console.WriteLine(true^false);

            int b = 0;
            Console.WriteLine(++b);
            Console.WriteLine(b++);

            Console.WriteLine("당신의 MBTI를 입력해주세요");
            string mumbti = Console.ReadLine();
            Console.WriteLine("나의 MBTI는" + mumbti + "입니다.");

            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("태어난 년도:"+ year+"년");

            Console.WriteLine(year.ToString());
            Console.WriteLine(year+"");
            Console.WriteLine(123.ToString());
            Console.WriteLine(123+"");

        }
    }
}
