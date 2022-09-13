using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalstudyroomMangement
{
    public partial class Form_mamber : Form
    {
        public Form_mamber()
        {
            InitializeComponent();

            if (DataManage.users.Count > 0)
                dataGridView1.DataSource = DataManage.users;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteLog(textBox_id.Text + "신규등록");

            if (textBox_id.Text.Trim() == "")
            { MessageBox.Show("Id를 입력해주세요");
                WriteLog("ID 미입력");
            }
            else if (textBox_name.Text.Trim() == "")
            { 
                MessageBox.Show("이름을 넣어주세요");
                WriteLog("이름 미입력");
            }
            else if (textBox_phone.Text.Trim() == "")
            {
                MessageBox.Show("연락처를 적어주세요");
                WriteLog("연락처 미입력");
            }
            else if (dateTimePicker_birth.Text == "") 
                MessageBox.Show("생일을 입력해주세요");
            else
            {
                try
                {
                    
                    if (DataManage.users.Exists((x) => x.Id == textBox_id.Text))
                    {
                        MessageBox.Show("이ID는 이미 존재하는 ID입니다..");
                    }
                    else
                    {
                        User user = new User()
                        {
                            Id = textBox_id.Text,
                            Name = textBox_name.Text,
                            Phone = textBox_phone.Text,
                            birth = dateTimePicker_birth.Value,
                            registerationday = DateTime.Now
                        };
                        DataManage.users.Add(user);

                        DataManage.Save
                            (textBox_id.Text, textBox_name.Text,
                            textBox_phone.Text, dateTimePicker_birth.Value, DateTime.Now);

                        string contents = $"ID : {textBox_id.Text}에 " +
                            $"{textBox_name.Text}님이 등록하셨습니다.";

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManage.users;
                        WriteLog(contents);
                        MessageBox.Show(contents);
                        
                    }
                }
                catch (Exception)
                {
                    string contents= $"ID등록이 실패하셨습니다.";
                    WriteLog(contents);
                    MessageBox.Show(contents);
                }
            }
            
        }
        private void WriteLog(string contents)
        {
            string logContents
                = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}]{contents}";
            DataManage.printLog(logContents);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteLog(textBox_id.Text + "정보변경");


            if (textBox_id.Text.Trim() == "")
            {
                MessageBox.Show("Id를 입력해주세요");
                WriteLog("ID 미입력");
            }
            else
            {

                try
                {
                    User user = DataManage.users.Single((x) => x.Id.ToString() == textBox_id.Text);

                    if (DataManage.users.Exists((x) => x.Id == textBox_id.Text))
                    {
                       
                        user.Name = textBox_name.Text;
                        user.Phone = textBox_phone.Text;
                        user.birth = dateTimePicker_birth.Value;


                        DataManage.Save
                            (textBox_id.Text, textBox_name.Text, textBox_phone.Text, dateTimePicker_birth.Value, DateTime.Now);

                        string contents = $"ID : {textBox_id.Text}에 " +
                            $"{textBox_name.Text}님이 정보변경 하셨습니다.";

                        WriteLog(contents);
                        MessageBox.Show(contents);
                    }
                }
                catch (Exception)
                {
                    string contents = $"정보 변경이 실패하셨습니다.";
                    WriteLog(contents);
                    MessageBox.Show(contents);
                }


            }
        }
    }
}
