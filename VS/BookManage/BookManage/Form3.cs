using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Text = "사용자관리";
            dataGridView1.DataSource = Datacontrol.Users;
    

            button_add.Click += (sendser, e) =>
            {
                try
                {
                    if (Datacontrol.Users.Exists((x) => x.Id == int.Parse(textBox_userId.Text)))
                    {
                        MessageBox.Show("이 사용자 ID는 이미 존재합니다.");
                    }
                    else
                    {
                        User user = new User()
                        {
                            Id = int.Parse(textBox_userId.Text),
                            Name = textBox_name.Text
                        };
                        Datacontrol.Users.Add(user);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Datacontrol.Users;
                        Datacontrol.Save();
                    }
                }
                catch (Exception)
                {

                }
            };

            button_modify.Click += (sendser, e) =>
            {
                try
                {
                    User user = Datacontrol.Users.Single((x) => x.Id == int.Parse(textBox_userId.Text));
                    user.Name = textBox_name.Text;
                    try
                    {
                        Book book = Datacontrol.Books.Single((x) => x.UserId == int.Parse(textBox_userId.Text));
                        book.UserName = textBox_name.Text;
                    }
                    catch (Exception)
                    {

                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Datacontrol.Users;
                    Datacontrol.Save();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("존재하지 않는 사용자입니다." + Environment.NewLine +
                        ee.GetType() + Environment.NewLine +
                        ee.Message + Environment.NewLine +
                        ee.StackTrace);
                }
            };

            button_delete.Click += (sender, e) =>
            {
                try
                {
                    User uesr = Datacontrol.Users.Single((x) => x.Id == int.Parse(textBox_userId.Text));
                    Datacontrol.Users.Remove(uesr);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Datacontrol.Users;
                    Datacontrol.Save();
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 사용자 입니다.");
                }
            };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                User user = dataGridView1.CurrentRow.DataBoundItem as User;
                textBox_userId.Text = user.Id.ToString();
                textBox_name.Text = user.Name;
            }
            catch (Exception)
            {

            }
        }
    }
}
