using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_220624_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Locale> locales = KaKaoAPI.Search(textBox1.Text);
            listBox1.Items.Clear();
            foreach(Locale item in locales)
                listBox1.Items.Add(item);
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick(); //버튼 1을 누를때와 같은 효과
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return; //인덱스값 잘못들어가면 종료

            //클릭한 부분을 Locale로 형변환
            Locale ml = listBox1.SelectedItem as Locale;
            object[] pos = new object[] { ml.Lat, ml.Lng };
            HtmlDocument hdoc = webBrowser1.Document;
            hdoc.InvokeScript("setCenter", pos);

        }
    }
}
