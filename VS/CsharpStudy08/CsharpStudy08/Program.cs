using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStudy08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human hm = new Human();
            Workder wd = new Workder();
            Student sd = new Student();

            hm.age = 12;
            hm.name = "박가가";
            hm.sleep();

            wd.age = 33;
            wd.name = "자립형";
            wd.sleep();  //name, age, sleep은 상소갑ㄷ은것
            wd.pay = 0;
            int money = wd.work();
            Console.WriteLine(money+"받음");
            wd.pay = 5200;
            money = wd.work();
            Console.WriteLine(money + "받음");


            sd.age = 10;
            sd.name = "중2병";
            sd.score = 60;
            sd.Study(8);
            sd.sleep();

            Console.WriteLine("----------");
            Human h2 = new Human();
            h2.age = 31;
            h2.name = "조나나";
            Human h3 = new Human();
            h3.age = 24;
            h3.name = "강다다";

            Student s2 = new Student();
            s2.name = "지라라";
            s2.age = 14;
            s2.score = 77;
            
            Student s3 = new Student();
            s3.name = "고마마";
            s3.age = 19;
            s3.score = 85;

            Workder w2=new Workder();
            w2.name = "지바바";
            w2.age = 27;
            w2.pay = 10000;
            Workder w3=new Workder();
            w3.name = "최사사";
            w3.age = 21;
            w3.pay = 5000;


            List<Human> humans = new List<Human>();
            humans.Add(hm);
            humans.Add(h2);
            humans.Add(h3);
           
            List<Student> students = new List<Student>();
            students.Add(sd);
            students.Add(s2);
            students.Add(s3);
            
            List<Workder> workder = new List<Workder>();
            workder.Add(wd);
            workder.Add(w2);
            workder.Add(w3);

            foreach(var item in humans)
            {
                item.sleep();
            }
            foreach(var item in students)
            {
                item.Study(10);
                item.sleep();
            }
            foreach(var item in workder)
            {
                int mypay = item.work();
                Console.WriteLine("내일"+mypay);
                item.sleep();
            }

            //다형성을 이용하면 1개의 foreach문 1개의 List로 9개의 데이터 모두 넣을 수 있다.
            //다형성 : 다양한 형태를 띌 가능성
            //왼쪽은 조상클랙스 오른쪽은 왼쪽의 자손이어야함
            Human ex1 = new Student();
            Human ex2 = new Workder();
            //  조상  = new   자손   ->이렇게 형변환가능  일명 is 법칙이 가능  -> Student is Humane, Workder is Human;
            ((Student)ex1).Study(5); //student가 자손이기에 가능
            (ex1 as Student).sleep();

            Console.WriteLine("---------------2222");

            List<Human> people = new List<Human> { hm,h2,h3,sd,s2,s3,wd,w2,w3};

            foreach (var item in people)
            {
                item.sleep();
                if (item is Student) { (item as Student).Study(1); }
                if(item is Workder) 
                {
                    int m = (item as Workder).work();
                    Console.WriteLine(m+"원");
                }
            }
        }
    }
}
