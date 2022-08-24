using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice01
{
    public class Lion :Cat
    {

        public int countOfWife { get; set; }

        public void CryOut()
        {
            countOfWife++;
            Console.WriteLine(Name+"은 동물원에 있는 "+countOfWife+"번째 암사자다");
            System.Windows.Forms.MessageBox.Show(Name + "은 동물원에 있는 " + countOfWife + "번째 암사자다");
        } 
    }
}
