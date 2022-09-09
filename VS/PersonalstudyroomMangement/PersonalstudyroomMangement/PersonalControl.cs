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
        Registration registration = new Registration();
        public int seatNum = 0;
        public int roomNum = 0;
        public PersonalControl()
        {
            InitializeComponent();                    
        }


        //public PersonalControl(int seatnum, int roomnum)
        //{
        //    seatNum = seatnum;
       //     roomNum = roomnum;
       // }

        private void b201_1_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
          
            registration.seatNum = seatNum = 1;
            registration.roomNum = roomNum = 201;
            try
            {
                Form_charge temp = new Form_charge(seatNum,roomNum);
                temp.ShowDialog();
            }
            catch (Exception)
            {

            }
            
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
    }
}
