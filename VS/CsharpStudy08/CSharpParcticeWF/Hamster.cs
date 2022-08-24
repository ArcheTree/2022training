using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice01
{
    public class Hamster : Animal
    {
        public string species { get; set; }

        public void run()
        {
            Console.WriteLine(Name+"이/가 "+species+"종 답게 챗바퀴를 돌리고 있습니다.");
            System.Windows.Forms.MessageBox.Show(Name + "이/가 " + species + "종 답게 챗바퀴를 돌리고 있습니다.");
        }

       
    }
}
