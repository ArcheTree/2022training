using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalstudyroomMangement
{
    public partial class Form_charge : Form
    {
        int seatNum = 0;
        int roomNum = 0;
        int billing = 0;

        public Form_charge(int seatnum, int roomnum)
        {
            InitializeComponent();
            int temp = seatnum;
            string temp2 = temp.ToString();
            label_setNum.Text = temp2;
            roomNum = roomnum;

        }
     

        private void domainUpDown_day_SelectedItemChanged(object sender, EventArgs e)
        {
            if(roomNum == 201 ||roomNum == 202 ||roomNum == 203)
            { 
                if (domainUpDown_day.SelectedItem.Equals("1일"))
                {
                    label_money.Text = "8,000원";
                    billing = 8000;
                    dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(1);
                }
                else if (domainUpDown_day.SelectedItem.Equals("7일(1주일)"))
                {
                    label_money.Text = "52,000원";
                    billing = 52000;
                    dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(7);
                }
                else if (domainUpDown_day.SelectedItem.Equals("15일"))
                {
                    label_money.Text = "85,000원";
                    billing = 85000;
                    dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(15);
                }
                else if (domainUpDown_day.SelectedItem.Equals("30일"))
                {
                    label_money.Text = "150,000원";
                    billing = 150000;
                    dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(30);
                }
            }
            else
                {
                    if (domainUpDown_day.SelectedItem.Equals("1일"))
                    {
                        label_money.Text = "6,000원";
                    billing = 6000;
                        dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(1);
                    }
                    else if (domainUpDown_day.SelectedItem.Equals("7일(1주일)"))
                    {
                        label_money.Text = "40,000원";
                        billing = 40000;
                        dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(7);
                    }
                    else if (domainUpDown_day.SelectedItem.Equals("15일"))
                    {
                        label_money.Text = "75,000원";
                        billing = 75000;
                        dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(15);
                    }
                    else if (domainUpDown_day.SelectedItem.Equals("30일"))
                    {
                        label_money.Text = "120,000원";
                        billing = 120000;
                        dateTimePicker_end.Value = dateTimePicker_start.Value.AddDays(30);
                    }
                }
            
        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{seatNum}번자리");
        }
    }
}
