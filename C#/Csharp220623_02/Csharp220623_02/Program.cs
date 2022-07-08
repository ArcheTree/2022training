using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp220623_02
{
    internal class Program
    {

      
      
  
    static void Main(string[] args)
        {
            List<Product> input = new List<Product>()
            {
            new Product(){ Name = "고구마", Price=1500},
            new Product(){ Name = "사과", Price=2400},
            new Product(){ Name = "바나나", Price=1000},
            new Product(){ Name = "배", Price=3000},
            new Product(){ Name = "감자", Price=1000},
            new Product(){ Name = "토마토", Price=2000},
            new Product(){ Name = "옥수수", Price=1500},

            };
            input.Add(new Product() { Name = "자두", Price = 500 });
            
            //ascending = DB의asc 임(오름차순 생략가능)
           var output = from item in input where item.Price > 1500 orderby item.Name ascending select item;

            foreach(var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            Console.WriteLine("2번");
            var output2 = from item in input orderby item.Price select item;
            foreach(var item in output2)
                Console.WriteLine(item);

            Console.WriteLine(" ");
            Console.WriteLine("3번");
            var output3 = from item in input orderby item.Price descending select item;
            foreach(var item in output3)
                Console.WriteLine(item);

            Console.WriteLine(" ");
            Console.WriteLine("4번");

            var output4 = from item in input select item.ToString();
            foreach(var item in output4)
                Console.WriteLine(item);

            Console.WriteLine(" ");
            Console.WriteLine("4번-2");
            var output4_2 = from item in input select item.Name + ":" + item.Price;
            foreach(var item in output4_2)
                Console.WriteLine(item);


            Console.WriteLine( "------------------------------------------");

            string url = "https://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            System.Xml.Linq.XElement xe = System.Xml.Linq.XElement.Load(url);
            Console.WriteLine(xe);

            Console.WriteLine( "------------------------------------------");

            var xQ = from item in xe.Descendants("data") select item;

            foreach(var item in xQ)
            {
                Console.WriteLine(item.Element("day").Value);
                Console.WriteLine(item.Element("temp").Value);
                Console.WriteLine(item.Element("wfKor").Value); 
            Console.WriteLine("--------------------------");

            List<Weather> w = new List<Weather>();
            foreach(var item in xe.Descendants("data"))
            {
                Weather temp = new Weather();
                temp.Name = item.Element("wfKor").Value;
                temp.Temp = double.Parse(item.Element("temp").Value);
                w.Add(temp);
            }
            foreach(var item in w)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Temp);

            }
           Console.WriteLine( "------------------------------------------");

            string url2 = "https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EC%A4%91%EA%B5%AC";
            System.Xml.Linq.XElement xe2 = System.Xml.Linq.XElement.Load(url);
            Console.WriteLine(xe2);

            Console.WriteLine( "------------------------------------------");

            var xQ2 = from item2 in xe.Descendants("data") select item;

            foreach(var item2 in xQ2)
            {
                Console.WriteLine(item.Element("OPENDATA_ID").Value);
               
            }
        }
    }
}
