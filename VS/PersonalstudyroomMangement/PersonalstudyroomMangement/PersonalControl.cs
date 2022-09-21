using System;
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
    public partial class PersonalControl : UserControl
    {
        public Button[] seat = new Button[30];
        Registration registration = new Registration();
        public int seatNum = 0;
        public int roomNum = 0;
        public PersonalControl()
        {
            InitializeComponent();
            seat[0]  = b201_1;  seat[1]  = b201_2;  seat[2] =  b201_3;  seat[3]  = b201_4;  seat[4]  = b201_5;  seat[5]  = b201_6;  seat[6]  = b201_7;  seat[7]  = b201_8;  seat[8]  = b201_9;  seat[9]  = b201_10; 
            seat[10] = b202_11; seat[11] = b202_12; seat[12] = b202_13; seat[13] = b202_14; seat[14] = b202_15; seat[15] = b202_16; seat[16] = b202_17; seat[17] = b202_18; seat[18] = b202_19; seat[19] = b202_20; 
            seat[20] = b203_21; seat[21] = b203_22; seat[22] = b203_23; seat[23] = b203_24; seat[24] = b203_25; seat[25] = b203_26; seat[26] = b203_27; seat[27] = b203_28; seat[28] = b203_29; seat[29] = b203_30;

           // int i = 0;
            //DataManage.seatcolorQuery(i + 1);

            //MessageBox.Show($"{seat[i]}는?{seat[i].BackColor}고 {DataManage.nowseats[0].endday}");

            for (int i = 0; i < seat.Length; i++)
            {
                DataManage.seatcolorQuery(i + 1);
                color(seat[i], DataManage.nowseats[0].endday);
                DataManage.nowseats.Clear();
            }

        }


 

        private void b201_1_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
          
            registration.seatNum = seatNum = 1;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum,roomNum);
            temp.ShowDialog();
           
        }

        private void b201_2_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 2;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_3_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 3;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_4_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 4;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_5_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 5;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_6_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();            
            registration.seatNum = seatNum = 6;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_7_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 7;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_8_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 8;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_9_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 9;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_10_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 10;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }
        private void color(Button l, DateTime endday)
        {

            if (endday == new DateTime()) // 빈자리
            {
                l.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
            else if (DateTime.Now.AddDays(7) >= endday && DateTime.Now.AddDays(7) < endday)  //7일전
            {
                l.BackColor = ColorTranslator.FromHtml("#ffcccc");
            }
            else if (DateTime.Now == endday) // 만료일
            {
                l.BackColor = ColorTranslator.FromHtml("ff0000");
            }
            else if (DateTime.Now.AddDays(7) < endday) //이용중
            {
                l.BackColor = ColorTranslator.FromHtml("#9999ff");
            }
   
        }
    }
}
