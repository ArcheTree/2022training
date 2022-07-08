using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp20610_WF
{
    public partial class Form1 : Form
    {

        int[] lottoN = new int[7];
        Label[] labels = new Label[7];
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            
            labels[0] = sort1;
            labels[1] = sort2;
            labels[2] = sort3;
            labels[3] = sort4;
            labels[4] = sort5;
            labels[5] = sort6;
            labels[6] = sort_bounus;

            


        }
        private void button_radom_Click(object sender, EventArgs e)
        {
           
            unduplication();

            labal_lotto1.Text = lottoN[0].ToString();
            labal_lotto2.Text = lottoN[1].ToString();
            labal_lotto3.Text = lottoN[2].ToString();
            labal_lotto4.Text = lottoN[3].ToString();  
            labal_lotto5.Text = lottoN[4].ToString();
            labal_lotto6.Text = lottoN[5].ToString();
            labal_lotto_bounus.Text = lottoN[6].ToString();
    
        }
        private void unduplication()
        {
            for (int i = 0; i < lottoN.Length; i++)
            {
                lottoN[i] = r.Next(1, 46);

                for (int j = 0; j < i; j++)
                {
                    if (lottoN[i] == lottoN[j])
                    {
                        i--;
                    }
                } // Console.WriteLine(arr[i]);
            }
            int nTemp;
            //int nCount = 0;

            for (int i = 0; i < lottoN.Length - 2; i++)
            {
                for (int j = 0; j < lottoN.Length - 2; j++)
                {
                    if (lottoN[j] > lottoN[j + 1])
                    {
                        nTemp = lottoN[j + 1];
                        lottoN[j + 1] = lottoN[j];
                        lottoN[j] = nTemp;
                    }
                }
            }


        }

              
       

        private void button3_Click(object sender, EventArgs e)
        {
            sort();
            sort1.Text = lottoN[0].ToString();
            sort2.Text = lottoN[1].ToString();
            sort3.Text = lottoN[2].ToString();
            sort4.Text = lottoN[3].ToString();
            sort5.Text = lottoN[4].ToString();
            sort6.Text = lottoN[5].ToString();
            sort_bounus.Text = lottoN[6].ToString();

            for (int i = 0; i < labels.Length; i++)
                color(labels[i]);
        }
        private void color(Label l)
        {
            Color c = new Color();
            int num = int.Parse(l.Text);
            if (num <= 10)
                l.BackColor = Color.Gold;
            else if (num > 10 && num <= 20)
            {
                l.BackColor = Color.DodgerBlue;
            }
            else if (num > 20 && num <= 30)
            {
                l.BackColor = Color.DarkOrange;
            }
            else if (num > 30 && num <= 40)
            {
                l.BackColor = Color.DimGray;
            }
            else if (num > 40 && num <= 45)
            {
                l.BackColor = Color.ForestGreen;
            }


        }
        private void sort()
        {
            int nTemp;
            //int nCount = 0;

            for (int i = 0; i < lottoN.Length - 2; i++)
            {
                for (int j = 0; j < lottoN.Length - 2; j++)
                {
                    if (lottoN[j] > lottoN[j + 1])
                    {
                        nTemp = lottoN[j + 1];
                        lottoN[j + 1] = lottoN[j];
                        lottoN[j] = nTemp;
                    }
                }
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            unduplication();

            labal_lotto1.Text = lottoN[0].ToString();
            labal_lotto2.Text = lottoN[1].ToString();
            labal_lotto3.Text = lottoN[2].ToString();
            labal_lotto4.Text = lottoN[3].ToString();
            labal_lotto5.Text = lottoN[4].ToString();
            labal_lotto6.Text = lottoN[5].ToString();
            labal_lotto_bounus.Text = lottoN[6].ToString();

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
            gb27.Text = lottoN[6].ToString();
        }

        private void button_random3_Click(object sender, EventArgs e)
        {
            unduplication();

            labal_lotto1.Text = lottoN[0].ToString();
            labal_lotto2.Text = lottoN[1].ToString();
            labal_lotto3.Text = lottoN[2].ToString();
            labal_lotto4.Text = lottoN[3].ToString();
            labal_lotto5.Text = lottoN[4].ToString();
            labal_lotto6.Text = lottoN[5].ToString();
            labal_lotto_bounus.Text = lottoN[6].ToString();

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
            gb27.Text = lottoN[6].ToString();

            unduplication();

            gb31.Text = lottoN[0].ToString();
            gb32.Text = lottoN[1].ToString();
            gb33.Text = lottoN[2].ToString();
            gb34.Text = lottoN[3].ToString();
            gb35.Text = lottoN[4].ToString();
            gb36.Text = lottoN[5].ToString();
            gb37.Text = lottoN[6].ToString();

        }

        private void button_random4_Click(object sender, EventArgs e)
        {
            unduplication();

            labal_lotto1.Text = lottoN[0].ToString();
            labal_lotto2.Text = lottoN[1].ToString();
            labal_lotto3.Text = lottoN[2].ToString();
            labal_lotto4.Text = lottoN[3].ToString();
            labal_lotto5.Text = lottoN[4].ToString();
            labal_lotto6.Text = lottoN[5].ToString();
            labal_lotto_bounus.Text = lottoN[6].ToString();

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
            gb27.Text = lottoN[6].ToString();

            unduplication();

            gb31.Text = lottoN[0].ToString();
            gb32.Text = lottoN[1].ToString();
            gb33.Text = lottoN[2].ToString();
            gb34.Text = lottoN[3].ToString();
            gb35.Text = lottoN[4].ToString();
            gb36.Text = lottoN[5].ToString();
            gb37.Text = lottoN[6].ToString();

            unduplication();

            gb41.Text = lottoN[0].ToString();
            gb42.Text = lottoN[1].ToString();
            gb43.Text = lottoN[2].ToString();
            gb44.Text = lottoN[3].ToString();
            gb45.Text = lottoN[4].ToString();
            gb46.Text = lottoN[5].ToString();
            gb47.Text = lottoN[6].ToString();

        }

        private void button_random5_Click(object sender, EventArgs e)
        {
            unduplication();

            labal_lotto1.Text = lottoN[0].ToString();
            labal_lotto2.Text = lottoN[1].ToString();
            labal_lotto3.Text = lottoN[2].ToString();
            labal_lotto4.Text = lottoN[3].ToString();
            labal_lotto5.Text = lottoN[4].ToString();
            labal_lotto6.Text = lottoN[5].ToString();
            labal_lotto_bounus.Text = lottoN[6].ToString();

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
            gb27.Text = lottoN[6].ToString();

            unduplication();

            gb31.Text = lottoN[0].ToString();
            gb32.Text = lottoN[1].ToString();
            gb33.Text = lottoN[2].ToString();
            gb34.Text = lottoN[3].ToString();
            gb35.Text = lottoN[4].ToString();
            gb36.Text = lottoN[5].ToString();
            gb37.Text = lottoN[6].ToString();

            unduplication();

            gb41.Text = lottoN[0].ToString();
            gb42.Text = lottoN[1].ToString();
            gb43.Text = lottoN[2].ToString();
            gb44.Text = lottoN[3].ToString();
            gb45.Text = lottoN[4].ToString();
            gb46.Text = lottoN[5].ToString();
            gb47.Text = lottoN[6].ToString();

            unduplication();

            gb51.Text = lottoN[0].ToString();
            gb52.Text = lottoN[1].ToString();
            gb53.Text = lottoN[2].ToString();
            gb54.Text = lottoN[3].ToString();
            gb55.Text = lottoN[4].ToString();
            gb56.Text = lottoN[5].ToString();
            gb57.Text = lottoN[6].ToString();

        }

        //private void button3_Paint(object sender, PaintEventArgs e)
        //{
        //    GraphicsPath g = new GraphicsPath();
        //    g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        //    this.Region = new Region(g);
        //    OnPaint(e);
        //}
    }
}
