using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp220623
{
    internal class Program
    {


        #region.수업

        static void Main(string[] args)
        {

            //배열, List
            //Stack이나  Queue도 있음

            //배열 : 미리 크기를 지정해야함
            int[] numbers1 = new int[5];

            //리스트-> 크기를 지정할 필요없음(add로 추가)
            List<int> numbers2 = new List<int>();

            numbers2.Add(1);
            numbers2.Add(100);
            numbers2.Add(21);
            numbers2.Add(324);
            numbers2.Insert(2, 399);
            numbers2.Remove(100);
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            Stack<int> numbers3 = new Stack<int>();
            numbers3.Push(1000);
            int temp = numbers3.Pop();

            Queue<int> numbers4 = new Queue<int>();
            numbers4.Enqueue(10);
            temp = numbers4.Dequeue();

            List<int> ex = new List<int>();
            ex.Add(10);
            ex.Add(15);
            ex.Add(20);
            ex.Add(25);
            ex.Add(30);
            ex.Add(35);

            List<int> myex = new List<int>();
            foreach (var item in ex)
            {
                if (item % 2 == 0)
                    myex.Add(item);
            }
            foreach (var item in myex)
                Console.WriteLine(item);

            //LINQ
            //SQL문을 사용하요 List에서 원한는 내용을 출력할수있음
            var myoutput = from item in ex where item % 2 != 0 select item;
            foreach (var item in myoutput)
            {
                Console.WriteLine(item);
            }

            List<int> numbers5 = (from item in ex where item % 2 != 1 select item).ToList();
            foreach (var item in numbers5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("익명개체 테스트");

            var numbers6 = from item in ex where item % 2 == 0 select new { level = item * 2, power = item / 2, money = item * item };

            foreach (var item in numbers6)
            {
                Console.WriteLine("level: " + item.level);
                Console.WriteLine("power: " + item.power);
                Console.WriteLine("money: " + item.money);
            }
        }
        #endregion

      
}
       

    }
}

