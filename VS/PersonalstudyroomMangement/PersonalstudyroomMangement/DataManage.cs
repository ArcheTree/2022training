using Microsoft.Win32;
using PersonalstudyroomMangement.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PersonalstudyroomMangement
{
    internal class DataManage
    {
        public static List<Registration> registrations = new List<Registration>();
        public static List<Registration> allregistration = new List<Registration>();
        public static List<Registration> expiredmembers = new List<Registration>();
        public static List<User> users = new List<User>();
        public static List<seatMng> nowseats = new List<seatMng>();
        static DataManage()
        {
            userLoad();
            SeatLoad();
            exLoad();
            DBseatMng.autoexpiredQuery();
        }
        public static void userLoad()
        {
            try
            {
                DBconnect.userselectQuery();
                users.Clear(); //Cars에 있는 내용 다 비움

                //selectQuery 통해서 dt에 값 넣었는 데
                //그걸 1줄씩 읽어들인다.
                foreach (DataRow item in DBconnect.dt.Rows)
                {
                    //ParkingCar 타입의 데이터 통해서 읽기
                    User car = new User();
                    car.Id = item["userId"].ToString();
                    car.Name = item["name"].ToString();
                    car.Phone = item["phone"].ToString();
                    car.birth = DateTime.Parse(item["birth"].ToString());
                    car.registerationday = DateTime.Parse(item["registerationDay"].ToString());
                    users.Add(car);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show("유저테이블");

            }
        }
        public static void SeatLoad()
        {
            try
            {
                DBregisteration.seatMngselectQuery();

                foreach (DataRow item in DBregisteration.dt.Rows)
                {
                    Registration seat = new Registration();

                    seat.registerNum = int.Parse(item["registerNum"].ToString());
                    seat.roomNum = int.Parse(item["roomNum"].ToString());
                    seat.seatNum = int.Parse(item["seatNum"].ToString());
                    seat.userId = item["userId"].ToString();
                    seat.startday = DateTime.Parse(item["startday"].ToString());
                    seat.endday = DateTime.Parse(item["endday"].ToString());
                    seat.pay = int.Parse(item["pay"].ToString());
                    registrations.Add(seat);
                }

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show("자리테이블");
            }
           

        }
        public static void exLoad()
        {
            try
            {
                DBregisteration.expiredcountQuery();
                Registration seat = new Registration();
                expiredmembers.Clear();

                foreach (DataRow item in DBregisteration.dt.Rows)
                {
                    seat.roomNum = int.Parse(item["roomNum"].ToString());
                    seat.seatNum = int.Parse(item["seatNum"].ToString());
                    seat.endday = DateTime.Parse(item["endday"].ToString());
                    expiredmembers.Add(seat);
                }
                
            }
            catch (Exception)
            {

               
            }
           
        }
        public static void search(string Query, string view)
        {
            try
            {
                DBregisteration.searchQuery(Query, view);

                Registration seat = new Registration();
                registrations.Clear();

                foreach (DataRow item in DBregisteration.dt.Rows)
                {
                    seat.roomNum = int.Parse(item["roomNum"].ToString());
                    seat.seatNum = int.Parse(item["seatNum"].ToString());
                    seat.userId = item["userId"].ToString();
                    seat.startday = DateTime.Parse(item["startday"].ToString());
                    seat.endday = DateTime.Parse(item["endday"].ToString());
                    registrations.Add(seat);
                }

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show("자리검색테이블");
            }
        }
        public static void registerLoad(DateTime onday, DateTime offday)
        {
            try
            {
                DBregisteration.registerselectQuery(onday,offday);

                allregistration.Clear();

                foreach (DataRow item in DBregisteration.dt.Rows)
                {
                    Registration register = new Registration();
                    
                    register.registerNum = int.Parse(item["registerNum"].ToString());
                    register.userId = item["userId"].ToString();
                    register.roomNum = int.Parse(item["roomNum"].ToString());
                    register.seatNum = int.Parse(item["seatNum"].ToString());
                    register.takeDay = DateTime.Parse(item["takeday"].ToString());
                    register.pay = int.Parse(item["pay"].ToString());
                    register.startday = DateTime.Parse(item["startday"].ToString());
                    register.endday = DateTime.Parse(item["endday"].ToString());
                    register.Description = item["description"].ToString();
                    register.refundpay = int.Parse(item["refundpay"].ToString());
                    allregistration.Add(register);
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public static void seatcolorQuery(int seatNum)
        {
            try
            {
                DBseatMng.seatMngselectQuery(seatNum);
                //nowseats.Clear();
                foreach (DataRow item in DBseatMng.dt.Rows)
                {
                    seatMng mng = new seatMng();
                    mng.seatNum = int.Parse(item["seatNum"].ToString());
                    mng.endday = item["endday"].ToString() == "" ? new DateTime() : DateTime.Parse(item["endday"].ToString());
                    nowseats.Add(mng);
                }
            }
            catch (Exception)
            {

            }
            
        }
       
        public static void printLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("PSRMngHistory");

            if (di.Exists == false)
                di.Create();
            using (StreamWriter w =
                new StreamWriter("PSRMngHistory\\PSRMngHistory.txt", true))
            {
                w.WriteLine(contents);
            }
        }
        public static void Save(string userId, string name, string phone, DateTime birth, DateTime registerationDay)
        {
            try
            {
                DBconnect.newbeQuery(userId, name, phone, birth, registerationDay);
            }
            catch (Exception)
            {

            }
        }
       
        public static void Save(string uesrid, int roomNum, int seatNum, DateTime takeday, DateTime startday, DateTime endday, int pay, string Description)
        {
            try
            {
                DBregisteration.newinsertQuery(uesrid, roomNum, seatNum, takeday ,startday, endday, pay, Description);
            }
            catch (Exception)
            {

            }
        }
        public static void updateUesr(string userId, string name, string phone)
        {
            try
            {
                DBconnect.modifiUserQuery(userId, name, phone);
            }
            catch (Exception)
            {

            }
        }

        public static void refundQuery(int registerNum, string Description,int refundpay)
        {
            DBregisteration.registerupdateQuery(registerNum, Description, DateTime.Now, refundpay);
        }
        public static void seatInfo(int seatNum, string userId, DateTime startday, DateTime endday)
        {
            DBseatMng.seatupdateQuery(seatNum, userId, startday, endday);
        }
    }

}
