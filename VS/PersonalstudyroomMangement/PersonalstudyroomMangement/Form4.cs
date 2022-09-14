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
            dataGridView1.DataSource =null;
            DataManage.registerLoad(dateTimePicker_start.Value, dateTimePicker_end.Value);
            dataGridView1.DataSource = DataManage.registrations;
        }

        private void dateTimePicker_end_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataManage.registerLoad(dateTimePicker_start.Value, dateTimePicker_end.Value);
            dataGridView1.DataSource = DataManage.registrations;

            if(dateTimePicker_start.Value > dateTimePicker_end.Value)
            {
                MessageBox.Show("날짜를 다시 지정해주세요");
                return;
            }
        }
    }
}
