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
    public partial class game : UserControl
    {
        int[] lottoN = new int[6];
        public CircularLabel[] labels = new CircularLabel[30];
        Random r = new Random();

        public game()
        {
            InitializeComponent();
            labels[0] = gb11;          labels[1] = gb12;            labels[2] = gb13;            labels[3] = gb14;            labels[4] = gb15;             labels[5] = gb16;        
            labels[6] = gb21;          labels[7] = gb22;            labels[8] = gb23;            labels[9] = gb24;            labels[10] = gb25;            labels[11] = gb26;   
            labels[12] = gb31;         labels[13] = gb32;           labels[14] = gb33;           labels[15] = gb34;           labels[16] = gb35;            labels[17] = gb36;    
            labels[18] = gb41;         labels[19] = gb42;           labels[20] = gb43;           labels[21] = gb44;           labels[22] = gb45;            labels[23] = gb46;      
            labels[24] = gb51;         labels[25] = gb52;           labels[26] = gb53;           labels[27] = gb54;           labels[28] = gb55;            labels[29] = gb56;           
                      
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = null;
                labels[i].BackColor = Color.White;
                labels[i].ForeColor = Color.White;
              

            }

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
            Array.Sort(lottoN);

            //int nTemp;
            ////int nCount = 0;

            //for (int i = 0; i < lottoN.Length - 1; i++)
            //{
            //    for (int j = 0; j < lottoN.Length - 1; j++)
            //    {
            //        if (lottoN[j] > lottoN[j + 1])
            //        {
            //            nTemp = lottoN[j + 1];
            //            lottoN[j + 1] = lottoN[j];
            //            lottoN[j] = nTemp;
            //        }
            //    }
            //}



        }
        private void color(CircularLabel l)
        {
            int num = int.Parse(l.Text);
            //Color c = new Color();
            
            if (num <= 10)
                //l.BackColor = Color.Gold;
                l.BackColor = ColorTranslator.FromHtml("#fbc400");
            else if (num > 10 && num <= 20)
            {
                //l.BackColor = Color.DodgerBlue;
                l.BackColor = ColorTranslator.FromHtml("#68c7f1");
            }
            else if (num > 20 && num <= 30)
            {
                //l.BackColor = Color.DarkOrange;
                l.BackColor = ColorTranslator.FromHtml("#ff7171");
            }
            else if (num > 30 && num <= 40)
            {
                //l.BackColor = Color.DimGray;
                l.BackColor = ColorTranslator.FromHtml("#aaaaaa");
            }
            else if (num > 40 && num <= 45)
            {
                //l.BackColor = Color.ForestGreen;
                l.BackColor = ColorTranslator.FromHtml("#add53f");
            }


        }

        private void one_Click(object sender, EventArgs e)
        {
            unduplication();

            gb11.Text = lottoN[0].ToString();
            gb12.Text = lottoN[1].ToString();
            gb13.Text = lottoN[2].ToString();
            gb14.Text = lottoN[3].ToString();
            gb15.Text = lottoN[4].ToString();
            gb16.Text = lottoN[5].ToString();
            

            for (int i = 0; i < 6; i++)
                color(labels[i]);
        }

        private void two_Click(object sender, EventArgs e)
        {
            

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
           
            for (int i = 6; i < 12; i++)
                color(labels[i]);
        }
        private void CButton_Click(object sender, EventArgs e)
        {
            unduplication();

            gb31.Text = lottoN[0].ToString();
            gb32.Text = lottoN[1].ToString();
            gb33.Text = lottoN[2].ToString();
            gb34.Text = lottoN[3].ToString();
            gb35.Text = lottoN[4].ToString();
            gb36.Text = lottoN[5].ToString();

            for (int i = 12; i < 18; i++)
                color(labels[i]);

        }


        private void four_Click(object sender, EventArgs e)
        {
           
            unduplication();

            gb41.Text = lottoN[0].ToString();
            gb42.Text = lottoN[1].ToString();
            gb43.Text = lottoN[2].ToString();
            gb44.Text = lottoN[3].ToString();
            gb45.Text = lottoN[4].ToString();
            gb46.Text = lottoN[5].ToString();
           
            for (int i = 18; i < 24; i++)
                color(labels[i]);
        }


        private void Ebutton_Click(object sender, EventArgs e)
        {
            unduplication();

            gb51.Text = lottoN[0].ToString();
            gb52.Text = lottoN[1].ToString();
            gb53.Text = lottoN[2].ToString();
            gb54.Text = lottoN[3].ToString();
            gb55.Text = lottoN[4].ToString();
            gb56.Text = lottoN[5].ToString();
            
            for (int i = 24; i < 30; i++)
                color(labels[i]);
        }
        private void three_Click(object sender, EventArgs e)
        {
            unduplication();

            gb11.Text = lottoN[0].ToString();
            gb12.Text = lottoN[1].ToString();
            gb13.Text = lottoN[2].ToString();
            gb14.Text = lottoN[3].ToString();
            gb15.Text = lottoN[4].ToString();
            gb16.Text = lottoN[5].ToString();
           

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();
           

            unduplication();

            gb31.Text = lottoN[0].ToString();
            gb32.Text = lottoN[1].ToString();
            gb33.Text = lottoN[2].ToString();
            gb34.Text = lottoN[3].ToString();
            gb35.Text = lottoN[4].ToString();
            gb36.Text = lottoN[5].ToString();
            
            for (int i = 0; i < 18; i++)
                color(labels[i]);
        }
        private void five_Click(object sender, EventArgs e)
        {
            unduplication();

            gb11.Text = lottoN[0].ToString();
            gb12.Text = lottoN[1].ToString();
            gb13.Text = lottoN[2].ToString();
            gb14.Text = lottoN[3].ToString();
            gb15.Text = lottoN[4].ToString();
            gb16.Text = lottoN[5].ToString();

            unduplication();

            gb21.Text = lottoN[0].ToString();
            gb22.Text = lottoN[1].ToString();
            gb23.Text = lottoN[2].ToString();
            gb24.Text = lottoN[3].ToString();
            gb25.Text = lottoN[4].ToString();
            gb26.Text = lottoN[5].ToString();

            unduplication();

            gb31.Text = lottoN[0].ToString();
            gb32.Text = lottoN[1].ToString();
            gb33.Text = lottoN[2].ToString();
            gb34.Text = lottoN[3].ToString();
            gb35.Text = lottoN[4].ToString();
            gb36.Text = lottoN[5].ToString();

            unduplication();

            gb41.Text = lottoN[0].ToString();
            gb42.Text = lottoN[1].ToString();
            gb43.Text = lottoN[2].ToString();
            gb44.Text = lottoN[3].ToString();
            gb45.Text = lottoN[4].ToString();
            gb46.Text = lottoN[5].ToString();

            unduplication();

            gb51.Text = lottoN[0].ToString();
            gb52.Text = lottoN[1].ToString();
            gb53.Text = lottoN[2].ToString();
            gb54.Text = lottoN[3].ToString();
            gb55.Text = lottoN[4].ToString();
            gb56.Text = lottoN[5].ToString();

            for (int i = 0; i < 30; i++)
                color(labels[i]);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = null;
                labels[i].BackColor = Color.White;
            }
        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void oneb_Click(object sender, EventArgs e)
        {
            string[] lotto = new string[30];
            for (int d = 0; d < lotto.Length; d++)
            {
                lotto[d] = labels[d].Text;

            }
            string j = string.Join(",", lotto);
            Form2 f2 = new Form2(j);
            f2.Show();
        }
    }
}
