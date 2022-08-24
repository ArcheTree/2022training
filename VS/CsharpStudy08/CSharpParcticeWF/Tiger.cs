using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice01
{
    public class Tiger :Cat
    {
        public string pattern { get; set; }

        public void Fight()
        {
            Console.WriteLine(pattern+"모양 무늬 호랑이가 재롱을 부리고 있습니다.");
            System.Windows.Forms.MessageBox.Show(pattern + "모양 무늬 호랑이가 재롱을 부리고 있습니다.");
        }
    }
}
