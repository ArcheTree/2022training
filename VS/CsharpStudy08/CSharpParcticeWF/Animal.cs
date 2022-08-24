using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice01
{
    public class Animal
    {
        public string Name { get; set; }
        public int age { get; set; }

        public void Sleep()
        {
            Console.WriteLine(Name+"이 잠에 빠집니다.");
        }
    }
}
