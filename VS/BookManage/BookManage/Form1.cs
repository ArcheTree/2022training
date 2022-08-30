using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "도서관 관리";

            //전체 도서 수
            label_AllBookCount.Text = Datacontrol.Books.Count.ToString();
            //사용자 수
            label_AllUserCount.Text = Datacontrol.Users.Count.ToString();
            //대출중인 도서의 수
            label_AllBorrowedBook.Text = Datacontrol.Books.Where((x) => x.isBorrowed).Count().ToString();
            //연체중인 도서의 수
            label_AllDelayedBook.Text = Datacontrol.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;
            }).Count().ToString();

            dataGridView_Bookbinding.DataSource = Datacontrol.Books;
            dataGridView_Userbinding.DataSource = Datacontrol.Users;

            
        }
        private void dataGridView_Userbinding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                User user = dataGridView_Userbinding.CurrentRow.DataBoundItem as User;
                textBox_userId.Text = user.Id.ToString();
            }
            catch (Exception)
            {

            }
        }


        private void dataGridView_Bookbinding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                Book book = dataGridView_Bookbinding.CurrentRow.DataBoundItem as Book;

                textBox_Isbn.Text = book.Isbn;
                textBox_bookName.Text = book.Name;

            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_Isbn.Text.Trim() == "")
            {
                MessageBox.Show("Isnb을 입력해주세요");
            }else if(textBox_userId.Text.Trim()==""){
                MessageBox.Show("사용자 Id를 입력해주세요");
            }
            else
            {
                try
                {
                    Book book = Datacontrol.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
                    if (book.isBorrowed)
                    {
                        MessageBox.Show("대여 중인 도서입니다.");
                    }
                    else
                    {
                        User user = Datacontrol.Users.Single((x) => x.Id.ToString() == textBox_userId.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView_Bookbinding.DataSource = null;
                        dataGridView_Bookbinding.DataSource = Datacontrol.Books;
                        Datacontrol.Save();

                        MessageBox.Show("\"" + book.Name + "\"이/가\"" + user.Name + "\"님께 대여되었습니다.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Isbn.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요.");
            }
            else
            {
                try
                {
                    Book book = Datacontrol.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
                    if (book.isBorrowed)
                    {
                        DateTime oldDay = book.BorrowedAt;
                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime();

                        dataGridView_Bookbinding.DataSource = null;
                        dataGridView_Bookbinding.DataSource = Datacontrol.Books;
                        Datacontrol.Save();

                        TimeSpan timeDiff = DateTime.Now - oldDay;
                        int diffDays = timeDiff.Days;

                        if (diffDays > 7)
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 연체 상태로 반납되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 반납되었습니다.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("대여상태가 아닙니다.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 temp = new Form2();
                temp.ShowDialog();
                Datacontrol.Load();
                dataGridView_Bookbinding.DataSource = null;
                dataGridView_Bookbinding.DataSource = Datacontrol.Books;
            }
            catch (Exception)
            {

            }
            
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Form3().ShowDialog();
                Datacontrol.Load();
                dataGridView_Userbinding.DataSource = null;
                dataGridView_Userbinding.DataSource = Datacontrol.Users;
                dataGridView_Bookbinding.DataSource = null;
                dataGridView_Bookbinding.DataSource = Datacontrol.Books;
            }
            catch (Exception)
            {
            }
        }
        private void dataFileBackup(string folderName)
        {
            DirectoryInfo di = new DirectoryInfo(folderName);
            if (!di.Exists)
            {
                di.Create();
            }
            string fileName_book = "Books.xml";
            string fileName_user = "Users.xml";
            string sourcPath = @".";
            string targetPath = @".\" + folderName;

            string sourceFile = Path.Combine(sourcPath, fileName_book);
            string desteFile = Path.Combine(targetPath, fileName_book);
            File.Copy(sourceFile, desteFile, true);

            sourceFile = Path.Combine(sourcPath, fileName_user);
            desteFile = Path.Combine(targetPath, fileName_user);
            File.Copy(sourceFile, desteFile, true );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataFileBackup("backupWhenLoad");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataFileBackup("backupWhenClose");
        }

    }
}
