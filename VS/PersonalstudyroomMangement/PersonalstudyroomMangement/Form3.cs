using PersonalstudyroomMangement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalstudyroomMangement
{
    public partial class Form_now : Form
    {
        public Form_now()
        {
            
            InitializeComponent();
            if (DataManage.registrations.Count > 0)
            {
                DataManage.SeatLoad();
                dataGridView1.DataSource = DataManage.registrations;
            }
            string contents = $"이용 현황 확인";
            WriteLog(contents);
        }


        private void WriteLog(string contents)
        {
            string logContents
                = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}]{contents}";
            DataManage.printLog(logContents);

        }

        private void button_serch_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox_Id.Text.Trim() != "")
                {
                    dataGridView1.DataSource = null;
                    string point = "userId";
                    DataManage.search(point,textBox_Id.Text);
                    dataGridView1.DataSource = DataManage.registrations;
                    string contents = $"ID({textBox_Id.Text}) 이용현황 검색";
                    WriteLog(contents);
                }
            }
            catch (Exception)
            {

            }
            try
            {
                if (textBox_room.Text.Trim() != "")
                {
                    dataGridView1.DataSource = null;
                    string point = "roomNum";
                    DataManage.search(point, textBox_room.Text);
                    dataGridView1.DataSource = DataManage.registrations;
                    string contents = $"방({textBox_room.Text}) 이용현황 검색";
                    WriteLog(contents);
                }
            }
            catch (Exception)
            {

            }
            try
            {
                if (textBox_seat.Text.Trim() != "")
                {

                    dataGridView1.DataSource = null;
                    string point = "seatNum";
                    DataManage.search(point, textBox_seat.Text);
                    dataGridView1.DataSource = DataManage.registrations;
                    string contents = $"자리({textBox_seat.Text}) 이용현황 검색";
                    WriteLog(contents);
                }
            }
            catch (Exception)
            {

            }
           
        }

    }
}

