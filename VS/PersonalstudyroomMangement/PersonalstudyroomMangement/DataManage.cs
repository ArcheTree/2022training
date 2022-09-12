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
            SeatLoad();
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
               
            }
        }
        public static void SeatLoad()
        {
            try
            {
                DBconnect.seatMngselectQuery();
                foreach (DataRow item in DBconnect.dt.Rows)
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
                DBconnect.dayselectQuerty(onday, offday);
            }
            catch (Exception)
            {

            }
        }
        public static void Save(string uesrid, int roomNum, int seatNum, DateTime startday, DateTime endday, int pay, string Description)
        {
            try
            {
                DBconnect.newinsertQuery(uesrid, roomNum, seatNum, startday, endday, pay, Description);
            }
            catch (Exception)
            {

            }
        }
        public static void Save(int seatNum, string uesrid, DateTime startday, DateTime endday)
        {
            try
            {
                DBconnect.PSRMngQuery(seatNum, uesrid, startday, endday);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
