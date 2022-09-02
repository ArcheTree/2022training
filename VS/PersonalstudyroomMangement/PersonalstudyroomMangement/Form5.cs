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
    public partial class Form_charge : Form
    {
        Registration registration= new Registration();
        string billing = "";

        public Form_charge()
        {
            InitializeComponent();
            label_money.Text = billing;
            label_setNum.Text = registration.seatNum.ToString();
        }

  
        private void domainUpDown_day_SelectedItemChanged(object sender, EventArgs e)
        {
            if(registration.roomNum == 201 || registration.roomNum == 202 || registration.roomNum == 203)

                if (domainUpDown_day.SelectedItem.Equals("1일"))
                {
                    label_money.Text = "8,000원";
                    dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(1);
                }
                else if (domainUpDown_day.SelectedItem.Equals("7일(1주일)"))
                {
                    label_money.Text = "52,000원";
                    dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(7);
                }
                else if (domainUpDown_day.SelectedItem.Equals("15일"))
                {
                    label_money.Text = "85,000원";
                    dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(15);
                }
                else if (domainUpDown_day.SelectedItem.Equals("30일"))
                {
                    label_money.Text = "150,000원";
                    dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(30);
                }
                else
                {
                    if (domainUpDown_day.SelectedItem.Equals("1일"))
                    {
                        label_money.Text = "6,000원";
                        dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(1);
                    }
                    else if (domainUpDown_day.SelectedItem.Equals("7일(1주일)"))
                    {
                        label_money.Text = "40,000원";
                        dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(7);
                    }
                    else if (domainUpDown_day.SelectedItem.Equals("15일"))
                    {
                        label_money.Text = "75,000원";
                        dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(15);
                    }
                    else if (domainUpDown_day.SelectedItem.Equals("30일"))
                    {
                        label_money.Text = "120,000원";
                        dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(30);
                    }
                }
            
        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{registration.seatNum}번자리 {registration.Name}님 {registration.startday}~{registration.endday}일까지 결제금 {registration.pay}입니다");
        }
    }
}
