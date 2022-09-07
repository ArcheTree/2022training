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
    public partial class Form_sale : Form
    {
        public Form_sale()
        {
            InitializeComponent();
        }

        private void dateTimePicker_start_ValueChanged(object sender, EventArgs e)
        {
           DataManage.DaySearch(dateTimePicker_start.Value, dateTimePicker_end.Value);
        }
  
    }
}
