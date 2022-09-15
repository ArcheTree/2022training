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
            seatNum = seatnum;
            string temp2 = temp.ToString();
            label_setNum.Text = temp2;
            roomNum = roomnum;
            DataManage.SeatLoad();
            if (DataManage.registrations.Exists((x) => x.seatNum == seatNum))
            {
                if (DataManage.registrations.Exists((x) => x.endday >= dateTimePicker_start.Value) || DataManage.registrations.Exists((x) => x.startday >= dateTimePicker_end.Value))
                {
                    MessageBox.Show("금일 이용중인 좌석입니다.");

                }

            }
        }


        private void domainUpDown_day_SelectedItemChanged(object sender, EventArgs e)
        {
            if (roomNum == 201 || roomNum == 202 || roomNum == 203)
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
            if (DataManage.registrations.Exists((x) => x.seatNum == seatNum))
            {
                if (DataManage.registrations.Exists((x) => x.endday >= dateTimePicker_start.Value))
                {
                    MessageBox.Show("등록기간중 이용중인 좌석입니다");
                    
                }
                
            }
            else if (DataManage.users.Exists((x) => x.Id == textBox_id.Text))
            {
                try
                {
                    Registration registrations = new Registration()
                    {
                        userId = textBox_id.Text,
                        roomNum = roomNum,
                        seatNum = seatNum,
                        pay = billing,
                        startday = dateTimePicker_start.Value,
                        endday = dateTimePicker_end.Value
                    };
                    DataManage.registrations.Add(registrations);

                    DataManage.Save(textBox_id.Text, roomNum, seatNum, DateTime.Now, dateTimePicker_start.Value, dateTimePicker_end.Value, billing, "");




                    string contents = $"ID : {textBox_id.Text}님이 {roomNum}호 {seatNum}번에 \n" +
                        $"{dateTimePicker_start.Value}~{dateTimePicker_end.Value}까지 이용하십니다. \n 결제 금액은 {billing}원입니다.";

                    WriteLog(contents);
                    MessageBox.Show(contents);
                }
                catch (Exception)
                {

                }

            }
            else
            {
                string contents = $"등록된 회원이 아닙니다. 등록 후 다시 결제를 진행해주세요";
                WriteLog(contents);
                MessageBox.Show(contents);
            }
           
            
        }
        private void WriteLog(string contents)
        {
            string logContents
                = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}]{contents}";
            DataManage.printLog(logContents);

        }
    }
}
