using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog ddd = new Dog();
            ddd.name = "징징";
            ddd.bark();
            ddd.code = "부암1212";
            ddd.sleep();


            Car c = new Car();
            Car c2 = new Car();

            c.carNumber = 9234;
            c2.carNumber = 2131;

            Dog d = new Dog();
            d.age = 7;
            d.name = "니니";
            d.beonho = "123124";
            d.code = "maltiz";

            d.bark();
            d.sleep();

            Dog d2 = new Dog();
            d2.age = 1;
            d2.name = "꼬꼬";
            d2.beonho = "1231";
            d2.code = "chiwawa";

            Dog.species = "반려견";
            //인스턴스 변수인 d와 d2에 들어가는 값이 다를 수 있다
            //클래스변수(species)는 모두 같은 값을 가진다.

            List<int> numbers = new List<int>();

            List<Dog> dogs = new List<Dog>();
            dogs.Add(d);
            dogs.Add(d2);
            dogs.Add(new Dog());
            dogs[2].age = 20;
            dogs[2].name = "부스";
            dogs[2].beonho = "가241";
            dogs[2].code = "mix";

            //int num = int.Parse(Console.ReadLine());
            //numbers.Add(num);

            //int check = int.Parse(Console.ReadLine());
            //numbers.Remove(check);

            
            //1번 숫자만 저장하는 리스트에 값 추가하기

            List<int> mynumbers = new List<int>();
            mynumbers.Add(20);
            Console.WriteLine("숫차하나 입력");
            int num2=int.Parse(Console.ReadLine());
            mynumbers.Add(num2);
            foreach (var i in mynumbers)
            {
                Console.WriteLine(i);
            }

            List<Dog> mydogs = new List<Dog>();
            Dog md = new Dog();
            md.age = 5;
            md.name = "꺼벙";
            md.beonho = "121";
            md.code = "mix";
            mydogs.Add(md);

            mydogs.Add(new Dog() { age = 3, name = "사탕", beonho = "사12", code = "b124" });

            Console.WriteLine("개 이름");
            string name = Console.ReadLine();
            Console.WriteLine("개 나이");
            int dog_age = int.Parse(Console.ReadLine());
            Console.WriteLine("개 번호");
            string dog_beonho = Console.ReadLine();
            Console.WriteLine("개 코드번호");
            string dog_code = Console.ReadLine();

            Dog temp = new Dog();
            temp.name = name;
            temp.age = dog_age;
            temp.beonho = dog_beonho;
            temp.code = dog_code;
            mydogs.Add(temp);


            //3번문제  숫자삭제
            Console.WriteLine("지우고 싶은 숫자");

            int n = int.Parse(Console.ReadLine());
            mynumbers.Remove(n);

            //4번 입력한 나이의 개 삭제
            Console.WriteLine("삭제할 개 나이");
            n = int.Parse(Console.ReadLine());

            //removeat 이용
            //제거 과정에서 역순(i--)로 하는것은 중간에 삭제후 길이가 변동되기에 역순으로 와야 반복이 완료됨
            for(var i = mydogs.Count-1; i >= 0; i--)
            {
                if (mydogs[i].age == n)
                {
                    mydogs.RemoveAt(i);
                }

            }
            //remove이용
            Console.WriteLine("삭제할 개 나이 하나더 골라");
            n = int.Parse(Console.ReadLine());
            for (int i = mydogs.Count - 1; i >=0; i--)
            {
                if (mydogs[i].age == n)
                {
                    Dog t = mydogs[i];
                    mydogs.Remove(t);
                }

            }

            foreach(var item in mynumbers)
            {
                Console.WriteLine(item);
            }
            foreach(var item in mydogs)
            {
                Dog mydog = item as Dog;
                Console.WriteLine(mydog.name + "_" + mydog.age);
            }
        }
    }
}
