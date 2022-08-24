using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice01
{
    public class Cat :Animal
    {
        public string eyeColor { get; set; }

        public void meow()
        {
            Console.WriteLine(eyeColor+"의 눈을 가진 고양이가");
            Console.WriteLine("울고있다.");
            Console.WriteLine("알고보니 그 고양이는 "+age+"살에 "+Name+"라고 불린다");
            System.Windows.Forms.MessageBox.Show(eyeColor + "의 눈을 가진 고양이가 울어요");
            System.Windows.Forms.MessageBox.Show("알고보니 그 고양이는 " + age + "살에 " + Name + "라고 불린다");
        }
    }
}
