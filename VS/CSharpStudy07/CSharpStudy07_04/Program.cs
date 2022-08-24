using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat ddd = new Cat();
            ddd.name = "식빵";
            ddd.age=4;
            ddd.color = "stripe";
            ddd.meow();
            ddd.eat();
            Cat.jump();




        }
    }
}
