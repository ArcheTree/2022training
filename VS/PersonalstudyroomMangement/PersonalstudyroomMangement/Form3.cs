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
    public partial class Form_now : Form
    {
        public Form_now()
        {
            InitializeComponent();

            if (DataManage.seatMngs.Count > 0)
                dataGridView1.DataSource = DataManage.seatMngs;
        }

    }
}
