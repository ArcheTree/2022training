using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalstudyroomMangement
{
    internal class DataManage
    {
        public static List<Registration> registrations = new List<Registration>();
        public static List<User> users = new List<User>();
        public static List<seatMng> seatMngs = new List<seatMng>();
        static DataManage()
        {
            userLoad();
            registerLoad();
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
                    car.registerationday = DateTime.Parse(item["registrationDay"].ToString());
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
                DBseatconnect.seatMngselectQuery();
                seatMngs.Clear();
                foreach (DataRow item in DBseatconnect.dt.Rows)
                {
                    seatMng seat = new seatMng();

                    seat.roomNum = int.Parse(item["roomNum"].ToString());
                    seat.seatNum = int.Parse(item["seatNum"].ToString());
                    seat.userId = item["userId"].ToString();
                    seat.startday = DateTime.Parse(item["startday"].ToString());
                    seat.endday = DateTime.Parse(item["endday"].ToString());
                    seatMngs.Add(seat);
                }

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show("자리테이블");
            }
           

        }
        public static void registerLoad()
        {
            try
            {
                DBregisteration.registerselectQuery();
                registrations.Clear();
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
                    registrations.Add(register);
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show("등록테이블");
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
        public static void DaySearch(DateTime onday, DateTime offday)
        {
            try
            {
                DBregisteration.dayselectQuerty(onday, offday);
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
        public static void Save(int seatNum, string uesrid, DateTime startday, DateTime endday)
        {
            try
            {
                DBseatconnect.PSRMngQuery(seatNum, uesrid, startday, endday);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
