using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice01
{
    public class Dog : Animal
    {
        public string hairColor { get; set; }

        public void bark()
        {
            Console.WriteLine("견공 "+Name+"께서는 " + age+"의 연세에 화려한 "+hairColor+"털을 휘날리며 짖으십니다.");
        }
    }
}
