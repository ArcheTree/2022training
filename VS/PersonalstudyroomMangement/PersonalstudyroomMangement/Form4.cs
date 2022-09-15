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
        int sales = 0;
        int refundcash = 0;
        public Form_sale()
        {
            InitializeComponent();
           
            
        }


        private void dateTimePicker_start_ValueChanged_1(object sender, EventArgs e)
        {
            dataGridView_detail.DataSource = null;
            DataManage.registerLoad(dateTimePicker_start.Value.AddDays(-1), dateTimePicker_end.Value);
            dataGridView_detail.DataSource = DataManage.allregistration;
            sumsale();
            refund();
            label_totalcount.Text = DataManage.allregistration.Count.ToString() + "건";
            label_sale.Text = sales.ToString() + "원";
            label_refund.Text = refundcash.ToString() + "원";
            label_finalsale.Text = (sales - refundcash).ToString() + "원";
        }

        private void dateTimePicker_end_ValueChanged_1(object sender, EventArgs e)
        {
            dataGridView_detail.DataSource = null;
            DataManage.registerLoad(dateTimePicker_start.Value.AddDays(-1), dateTimePicker_end.Value);
            dataGridView_detail.DataSource = DataManage.allregistration;
            sumsale();
            refund();
            label_totalcount.Text = DataManage.allregistration.Count.ToString() + "건";
            label_sale.Text = sales.ToString() + "원";
            label_refund.Text = refundcash.ToString() + "원";
            label_finalsale.Text = (sales - refundcash).ToString() + "원";
            if (dateTimePicker_start.Value > dateTimePicker_end.Value)
            {
                MessageBox.Show("날짜를 다시 지정해주세요");
                return;
            }
        }
        public int sumsale()
        {
            
            foreach (var list in DataManage.allregistration)
            {
                sales += list.pay;
            }
            return sales;
        }
        public int refund()
        {

            foreach (var list in DataManage.allregistration)
            {
                refundcash += list.refundpay;
            }
            return refundcash;
        }
    }
}
