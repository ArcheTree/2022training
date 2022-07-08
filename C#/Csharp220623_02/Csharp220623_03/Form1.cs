using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Csharp220623_03
{
    public partial class Form1 : Form
    {
        List<Weather> w = new List<Weather>();
        public Form1()
        {
            InitializeComponent();
           // bindingSource1.DataSource = w;
        }
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
           XElement xe = XElement.Load(url);
            foreach(var item in xe.Descendants("data"))
            {
                Weather t = new Weather();
                t.Name = item.Element("wfKor").Value;
                t.Temp = double.Parse(item.Element("temp").Value);
                w.Add(t);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = w;
        }
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            //https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=999

            int count = 1000; //1000회차부터 현재까지 출력

            List<Lotto> lottos= new List<Lotto>();

            while(true)
            {
                var jason = new WebClient().DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + count);
                    count++;
                var jArray = JObject.Parse(jason);
                if (jArray["returnValue"].ToString() == "fail")
                {
                    break;
                }

                Lotto l = new Lotto()
                {
                    drwNoDate = jArray["drwNoDate"].ToString(),
                    totSellamnt = jArray["totSellamnt"].ToString()
                   
                };
                lottos.Add(l);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lottos;
        }
    }
}
