using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07
{
    public partial class Dog
    {
        public string beonho { get; set; }
        public string code { get; set; }

        //종이름
        //static이 있어 모든 dog클래스에서 사용 -> 이걸 클래스 변수라고함
        //static이 없으면?  인스턴스 변수라고함
        public static string species { get; set; }

    }
}
