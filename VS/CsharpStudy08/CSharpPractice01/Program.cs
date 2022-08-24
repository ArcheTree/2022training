using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal an1 = new Animal();
            an1.Name = "나는곤충";
            an1.age = 2;

            Animal an2 = new Animal();
            an2.Name = "흰수염 고래";
            an2.age = 120;

            Dog d1 = new Dog();
            d1.Name = "루피";
            d1.age = 5;
            d1.hairColor = "LightGold";

            Dog d2 = new Dog();
            d2.Name = "조로";
            d2.age = 6;
            d2.hairColor = "Olive";

            Cat c1 = new Cat();
            c1.Name = "버기";
            c1.age = 7;
            c1.eyeColor = "빨강";

            Cat c2 = new Cat();
            c2.Name = "봉구레";
            c2.age = 2;
            c2.eyeColor = "검정";

            Hamster h1 = new Hamster();
            h1.Name = "서태웅";
            h1.age = 3;
            h1.species = "스코어러";

            Hamster h2 = new Hamster();
            h2.Name = "강백호";
            h2.age = 3;
            h2.species = "리바운더";

            Lion l1 = new Lion();
            l1.Name = "사바나";
            l1.age = 8;
            l1.eyeColor = "Brown";

            Lion l2 = new Lion();
            l2.Name = "타클라마";
            l2.age = 7;
            l2.eyeColor = "gray";

            Tiger t1 = new Tiger();
            t1.Name = "태국호";
            t1.age = 8;
            t1.eyeColor = "blue";
            t1.pattern = "stripe";

            Tiger t2 = new Tiger();
            t2.Name = "한국호";
            t2.age = 12;
            t2.eyeColor = "red";
            t2.pattern = "dot";



            List<Animal> animals = new List<Animal>() { an1,an2,d1,d2,c1,c2,h1,h2,l1,l2, t1,t2};


            foreach (var item in animals)
            {
                item.Sleep();
                if (item is Dog)
                {
                    (item as Dog).bark();
                }
                if (item is Cat)
                {
                    (item as Cat).meow();
                }
                if(item is Hamster)
                {
                    (item as Hamster).run();
                }
                if(item is Lion)
                {
                    (item as Lion).CryOut();
                }
                if(item is Tiger)
                {
                    (item as Tiger).Fight();
                }

            }
        }
    }
}
