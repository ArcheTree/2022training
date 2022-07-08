using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp220624_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int abs_multipl(string a1, string b1)
        {
            int a = int.Parse(a1);
            int b = int.Parse(b1);  

            if (a < 0)
                a *= -1;

            if(b < 0)
                b*= -1;

            return a * b;

        }

        void abs_muly(string a1, string a2)
        {
            int.TryParse(a1, out int a);
            int.TryParse(a2, out int b);
            //tryparse 의 경우 공백이면 0으로 저장
            MessageBox.Show("Test =>" + (a*b));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + int.Parse(textBox1.Text) * int.Parse(textBox2.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + abs_multipl(textBox1.Text,textBox2.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random ra=new Random();
            MessageBox.Show("Test" + ra.Next());

            abs_muly(textBox1.Text,textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Name = textBox3.Text;
            st.Study();

            Student.ShowCount();

            Student stt=new Student();
            stt.Name = st.Name + "짱짱";
            stt.Study();

            Student.ShowCount();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EliteStudent student = new EliteStudent();  
            student.Name = textBox3.Text;
            student.hackbeon = textBox4.Text;

            student.Study();
            student.대학생활();
        }
    }
}
