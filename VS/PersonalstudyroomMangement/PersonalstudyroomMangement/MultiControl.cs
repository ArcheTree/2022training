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
    public partial class MultiControl : UserControl
    {
        public Button[] seatm = new Button[20];
        Registration registration=new Registration();
        public int seatNum = 0;
        public int roomNum = 0;
        public MultiControl()
        {
            InitializeComponent();
            seatm[0] = m301_31; seatm[1] = m301_32; seatm[2] = m301_33; seatm[3] = m301_34; seatm[4] = m301_35; seatm[5] = m301_36; seatm[6] = m301_37; seatm[7] = m301_38; seatm[8] = m301_39; seatm[9] = m301_40;
            seatm[10] = m301_41; seatm[11] = m301_42; seatm[12] = m301_43; seatm[13] = m301_44; seatm[14] = m301_45; seatm[15] = m301_46; seatm[16] = m301_47; seatm[17] = m301_48; seatm[18] = m301_49; seatm[19] = m301_50;
           
            for (int i = 0; i < seatm.Length; i++)
            {
                DataManage.seatcolorQuery(i + 31);
                color(seatm[i], DataManage.nowseats[0].endday);
                DataManage.nowseats.Clear();
            }
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

        private void m301_31_Click(object sender, EventArgs e)
        {
            DataManage.registrations.Clear();
            registration.seatNum = seatNum = 31;
            registration.roomNum = roomNum = 301;
            Form_charge temp = new Form_charge(seatNum, roomNum);
            temp.ShowDialog();
        }
    }
}
