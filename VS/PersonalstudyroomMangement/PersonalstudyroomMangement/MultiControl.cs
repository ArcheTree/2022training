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
        public MultiControl()
        {
            InitializeComponent();
        }

        private void m301_31_Click(object sender, EventArgs e)
        {
          //  registration.seatNum = 031;
          //  registration.roomNum = 201;
          //  Form_charge temp = new Form_charge(int);
          //  temp.ShowDialog();
        }
    }
}
