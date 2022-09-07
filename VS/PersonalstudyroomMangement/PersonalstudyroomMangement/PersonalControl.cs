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
        public int seatNum = 0;
        public int roomNum = 0;

        Registration registration = new Registration();
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
            seatNum = 1;
            roomNum = 201;
            registration.seatNum = 1;
            registration.roomNum = 201;
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
            seatNum = 2;
            roomNum = 201;
            registration.seatNum = 1;
            registration.roomNum = 202;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_3_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            seatNum = 3;
            roomNum = 201;
            registration.seatNum = 1;
            registration.roomNum = 203;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_4_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            seatNum = 4;
            roomNum = 201;
            registration.seatNum = 4;
            registration.roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_5_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            seatNum = 5;
            roomNum = 201;
            registration.seatNum = 5;
            registration.roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_6_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            seatNum = 6;
            roomNum = 201;
            registration.seatNum = 6;
            registration.roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_7_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 6;
            registration.roomNum = roomNum = 201;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }

        private void b201_8_Click(object sender, EventArgs e)
        {

        }

        private void b201_9_Click(object sender, EventArgs e)
        {

        }

        private void b201_10_Click(object sender, EventArgs e)
        {

        }
    }
}
