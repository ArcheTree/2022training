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
        Registration registration=new Registration();
        public int seatNum = 0;
        public int roomNum = 0;
        public MultiControl()
        {
            InitializeComponent();
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
