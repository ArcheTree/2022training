using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalstudyroomMangement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainControl1.BringToFront();
            label_timer.Text
                = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");
        }
        private void timer_main_Tick(object sender, EventArgs e)
        {
            label_timer.Text
                = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            mainControl1.BringToFront();
        }

        private void button_personal_Click(object sender, EventArgs e)
        {
            personalControl1.BringToFront();
        }

        private void button_multy_Click(object sender, EventArgs e)
        {
            multiControl1.BringToFront();
        }

        private void 신규등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form_mamber temp = new Form_mamber();
                temp.ShowDialog();
            }
            catch (Exception)
            {

            }
            
        }

        private void 이용현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form_now temp = new Form_now();
                temp.ShowDialog();
            }
            catch (Exception)
            {

            }
          
        }

        private void 매출관련ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form_sale temp = new Form_sale();
                temp.ShowDialog();
            }
            catch (Exception)
            {

            }
    ;
        }

    }
}
