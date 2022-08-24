using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpStudy07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.name = textBox1.Text;
            int.TryParse(textBox2.Text, out int age);
            c.age = age;

            c.meow();
            string message = c.eat();
            MessageBox.Show(message);

            Cat.jump();

            Cat c2 = new Cat();
            c2.name = textBox3.Text;
            int.TryParse(textBox4.Text, out int age2);
            c2.age = age2;

            c2.meow();
            string massageplus = c2.eat();
            MessageBox.Show(massageplus);

            Cat.jump();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cat c2 = new Cat();
            c2.name = textBox3.Text;
            int.TryParse(textBox4.Text, out int age2);
            c2.age = age2;
            c2.color = textBox5.Text;

            c2.meow();
            int.TryParse(textBox6.Text, out int count);
            string massageplus = c2.eat();
            MessageBox.Show(massageplus);
            c2.shout(count);
            Cat.jump();

            
        }
    }
}
