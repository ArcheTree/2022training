using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prack123
{
    internal class Program
    {
        static void Main(string[] args)
        {
        List<SeeSite> st = new List<SeeSite>();
            Console.WriteLine("------------------------------------------");

            string url = "	https://apis.data.go.kr/6270000/getTourKorAttract/getTourKorAttractList?serviceKey=9YOMht5qQSTf95oRQrysRM0VDZC0OOz3gZthTQ0SThAHJrfHxlzM5z6zLx3oOcXDIjTHHgKmbNp3lq6UXVR32g%3D%3D&pageNo=1&numOfRows=10";
            XElement xe = XElement.Load(url);
            Console.WriteLine(xe);

            Console.WriteLine("------------------------------------------");

            var xQ2 = from item in xe.Descendants("item") select item;

            foreach (var item in xQ2)
            {
                SeeSite ss=new SeeSite();
                ss.Address = item.Element("address").Value;
                
                st.Add(ss);
            }
        }
    }
}
