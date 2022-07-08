using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp220624_02
{
    public class Student
    {

        //static 클래스 변수나 클래스 메소드
        public string Name { get; set; }  //인스턴스 변수

        public static int count { get; set; } //클래스 변수

        public string hackbeon { get; set; }

        public Student()
        {
            count++;
        }

        public void Study()
        {
            System.Windows.Forms.MessageBox.Show(Name + " 학생이다.");
        }

        public void Study(int a)
        {
            for (int i=0; i < a; i++)
                System.Windows.Forms.MessageBox.Show(Name+"의 공부");

        }

        public static void ShowCount()
        {
            System.Windows.Forms.MessageBox.Show("이 학교 인원은" + count + "명이다.");


        }
        protected void sleep()
        {
            System.Windows.Forms.MessageBox.Show(Name+"은 졸고있다");
            System.Windows.Forms.MessageBox.Show(hackbeon+"학번은 이미....");
        }

    }
}
