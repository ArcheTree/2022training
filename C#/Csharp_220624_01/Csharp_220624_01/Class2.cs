using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Csharp_220624_01
{
    internal class KaKaoAPI
    {
        public static List<Locale> Search(string text)
        {
            List<Locale> list = new List<Locale>();

            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query = $"{site}?query={text}"; //api 호출 쿼리(키워드 포함)

            string restApiKey = "02557a3f68bdc7bb0da53e63cd45965b";
            string Header = $"KakaoAK {restApiKey}";

            WebRequest request = WebRequest.Create(query);
            request.Headers.Add("Authorization", Header);

            WebResponse response = request.GetResponse();//요청보냄
            Stream stream =response.GetResponseStream(); //응답받은 자료를 저장
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            string json = reader.ReadToEnd();//응답은 json 형태로 옴

            JavaScriptSerializer js = new JavaScriptSerializer();

            //c#의 var = 한번 자료형이 정해지면 안바뀜
            //dynamic = g한번 자료형이 정해져도 다시 바뀜
            //자바크르립트의var랑 let이 이거랑 똑같은 것

            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;

            int length=buf.Length;
            for (int i = 0;i < length ; i++)
                {
                string iname = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                list.Add(new Locale(iname, y, x));
                 }


            return list;

        }

    }
}
