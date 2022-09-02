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
        Registration registration=new Registration();
        public PersonalControl()
        {
            InitializeComponent();
        }

        private void b201_1_Click(object sender, EventArgs e)
        {
            try
            {
                registration.seatNum = 001;
                registration.roomNum = 201;
                Form_charge temp = new Form_charge();
                temp.ShowDialog();
            }
            catch (Exception)
            {

            }
            
        }

        private void b201_2_Click(object sender, EventArgs e)
        {
            registration.seatNum = 001;
            registration.roomNum = 201;
            Form_charge temp = new Form_charge();
            temp.ShowDialog();
        }

        private void b201_3_Click(object sender, EventArgs e)
        {
            registration.seatNum = 001;
            registration.roomNum = 201;
            Form_charge temp = new Form_charge();
            temp.ShowDialog();
        }

        private void b201_4_Click(object sender, EventArgs e)
        {
            registration.seatNum = 001;
            registration.roomNum = 201;
            Form_charge temp = new Form_charge();
            temp.ShowDialog();
        }

        private void b201_5_Click(object sender, EventArgs e)
        {
            registration.seatNum = 001;
            registration.roomNum = 201;
            Form_charge temp = new Form_charge();
            temp.ShowDialog();
        }

        private void b201_6_Click(object sender, EventArgs e)
        {
            registration.seatNum = 001;
            registration.roomNum = 201;
            Form_charge temp = new Form_charge();
            temp.ShowDialog();
        }

        private void b201_7_Click(object sender, EventArgs e)
        {
            registration.seatNum = 001;
            registration.roomNum = 201;
            Form_charge temp = new Form_charge();
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
