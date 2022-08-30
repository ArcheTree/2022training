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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "도서 관리";

            dataGridView1.DataSource = Datacontrol.Books;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(Datacontrol.Books.Exists((x)=>x.Isbn == textBox_isbn.Text))
                {
                    MessageBox.Show("이미 등록된 도서입니다.");
                }
                else
                {
                    Book book = new Book()
                    {
                        Isbn = textBox_isbn.Text,
                        Name = textBox_bookname.Text,
                        Publisher = textBox_publisher.Text,
                        Page = int.Parse(textBox_page.Text)
                    };
                    Datacontrol.Books.Add(book);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Datacontrol.Books;
                    Datacontrol.Save();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = Datacontrol.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                book.Name = textBox_bookname.Text;
                book.Publisher = textBox_publisher.Text;
                book.Page = int.Parse(textBox_page.Text);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Datacontrol.Books;
                Datacontrol.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("없는 도서 입니다."); 
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = Datacontrol.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                Datacontrol.Books.Remove(book);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Datacontrol.Books;
                Datacontrol.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("없는 도서 입니다.");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                textBox_isbn.Text = book.Isbn;
                textBox_bookname.Text = book.Name;
                textBox_publisher.Text = book.Publisher;
                textBox_page.Text = book.Page.ToString();

            }
            catch (Exception)
            {

             
            }
        }
    }
}
