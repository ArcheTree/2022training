using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07_04
{
    public partial class Cat
    {
        public void meow()
        {
            if(age <= 1)
            {
                Console.WriteLine(name+"이 배가 고프다고 울고있습니다.");
            }
            else{
                Console.WriteLine(age+"살 먹은 "+ name +"이/가 발정나 흥분했습니다.");
            }
        }
        public void eat()
        {
            if (age <=3)
            {
                Console.WriteLine(name + "이 집사에게 사료를 내놓으라 합니다.");
            }
            else
            {
                Console.WriteLine(age + "살로 연로한  " + name + "이/가 이가 아프니 츄르를 달라고 합니다..");
            }
        }
        //클래스가 메소드
        //인스턴스별로 다르게 동작하는 것은 아니라 한클래스가 모두 공유하는 메소드(클래스 변수와 마찬가지로  static 키워드가 필요함)
        public static void jump()
        {
            Console.WriteLine("모든 고양이는 점프를 하기에 투명유리창이나 판을 집안에 두지 말아주세요");
        }
    }
}
