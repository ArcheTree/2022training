using CSharpPractice01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpParcticeWF
{
    public partial class Form1 : Form
    {
            List<Animal> animals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal an1 = new Animal();
            an1.Name = textBox_name.Text;
            an1.age = int.Parse(textBox_age.Text);
            animals.Add(an1);
            an1.Sleep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dog d1 = new Dog();
            d1.Name = textBox_name.Text;
            d1.age = int.Parse(textBox_age.Text);
            d1.hairColor = textBox_haircolor.Text;
            animals.Add(d1);
            d1.Sleep();
            d1.bark();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cat c1 = new Cat();
            c1.Name = textBox_name.Text;
            c1.age = int.Parse(textBox_age.Text);
            c1.eyeColor = textBox_eyecolor.Text;
            animals.Add(c1);
            c1.Sleep();
            c1.meow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hamster h1 = new Hamster();
            h1.Name = textBox_name.Text;
            h1.age = int.Parse(textBox_age.Text);
            h1.species = textBox_species.Text;
            animals.Add(h1);
            h1.Sleep();
            h1.run();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lion l1 = new Lion();
            l1.Name = textBox_name.Text;
            l1.age = int.Parse(textBox_age.Text);
            l1.eyeColor = textBox_eyecolor.Text;
            animals.Add(l1);
            l1.Sleep();
            l1.meow();
            l1.CryOut();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tiger t1 = new Tiger();
            t1.Name = textBox_name.Text;
            t1.age = int.Parse(textBox_age.Text);
            t1.eyeColor = textBox_eyecolor.Text;
            t1.pattern = textBox_pattern.Text;
            animals.Add(t1);
            t1.Sleep();
            t1.meow();
            t1.Fight();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // animals = new List<Animal>();
            animals.Clear();
        }



        private void button8_Click(object sender, EventArgs e)
        {
            Console.WriteLine(animals);
            
        }
    }
}
