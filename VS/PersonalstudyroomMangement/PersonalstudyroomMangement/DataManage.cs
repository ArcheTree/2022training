using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalstudyroomMangement
{
    internal class DataManage
    {
        public static List<Registration> registrations = new List<Registration>();
        public static List<User> users = new List<User>();
        static DataManage()
        {
            userLoad();
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
    }
}
