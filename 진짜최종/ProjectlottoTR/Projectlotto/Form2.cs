using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectlotto
{
    public partial class Form2 : Form
    {
        game org=new game();
        public Form2()
        {
            InitializeComponent(); 
        }
        public Form2(string i)
        {
            InitializeComponent();
            if (i != "")
            {
                string[] test = i.Split(',');
                label1.Text = test[0];  label2.Text = test[1];   label3.Text = test[2];     label4.Text = test[3];  label5.Text = test[4];           label6.Text = test[5];
                label7.Text = test[7];  label8.Text = test[8];   label9.Text = test[9];     label10.Text = test[10];  label11.Text = test[11];           label12.Text = test[12];
                label13.Text = test[14];  label14.Text = test[15];   label15.Text = test[16];     label16.Text = test[17];  label17.Text = test[18];           label18.Text = test[19];
                label19.Text = test[21];  label20.Text = test[22];   label21.Text = test[23];     label22.Text = test[24];  label23.Text = test[25];           label24.Text = test[26];
                label25.Text = test[28];  label26.Text = test[29];   label27.Text = test[30];     label28.Text = test[31];  label29.Text = test[32];           label30.Text = test[33];
               

            }
        }
    }
}
