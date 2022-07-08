using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp220609_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {


                Console.WriteLine("시간을 입력하세요");
                int hour = int.Parse(Console.ReadLine());
                if (hour < 12)
                {
                    Console.WriteLine("오전 입니다.");
                }
                if (hour >= 12)
                {
                    Console.WriteLine("오후 입니다.");
                }
                if (hour < 0 || hour > 24)
                    Console.WriteLine("가능하다고 생각하심?");


                if (hour > 0 && hour % 2 != 0)
                    Console.WriteLine(hour + "값은 홀수");
                else
                    Console.WriteLine(hour + "값은 양수");


                if (hour > 12)
                {
                    if (hour % 2 != 0)
                    {
                        Console.WriteLine("오후에 짝수");
                    }
                }
            }
            else
            {

            }
        }
    }
}
