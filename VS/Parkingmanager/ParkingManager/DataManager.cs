using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars 
            = new List<ParkingCar>();

        //정적 생성자
        //DataManager에 접근하려고 할 때 불러와짐
        //딱 한 번만 불러오고
        //해당 클래스에 접근할 때 자동으로 불러와진다.
        static DataManager()
        {
            Load();
        }
        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear(); //Cars에 있는 내용 다 비움

                //selectQuery 통해서 dt에 값 넣었는 데
                //그걸 1줄씩 읽어들인다.
                foreach(DataRow item in DBHelper.dt.Rows)
                {
                    //ParkingCar 타입의 데이터 통해서 읽기
                    ParkingCar car = new ParkingCar();
                    car.ParkingSpot
                        = int.Parse(item["parkingSpot"].ToString());
                    car.carNumber = item["carNumber"].ToString();
                    car.driverName = item["driverName"].ToString();
                    car.phoneNumber = item["phoneNumber"].ToString();
                    car.parkingTime = item["parkingTime"].ToString() == "" ?
                        new DateTime() : 
                        DateTime.Parse(item["parkingTime"].ToString());
                    Cars.Add(car);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
               // throw;
            }
        }

        //ParkingHistory 폴더의 ParkingHistory 텍스트 파일에
        //내용을 적는 메소드
        public static void printLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");

            //해당 폴더가 없을 때 새로 만든다는 의미
            if (di.Exists == false)
                di.Create();

            //true의 의미
            //새로 내용 추가시 확장(append)하겠단 의미

            //using : 중괄호 끝나면 해당 메모리 자동 삭제
            using(StreamWriter w = 
                new StreamWriter("ParkingHistory\\ParkingHistory.txt", true))
            {
                w.WriteLine(contents);
            }
        }

        //주차 및 출차를 할 것
        public static void Save(string parkingSpotText, string carNumber, 
            string driverName, string phoneNumber, bool isRemove=false)
        {
            try
            {
                //update를 하는 데
                //isRemove 값에 따라서
                //주차 혹은 출차 상태를 반영할 것
                DBHelper.updateQuery(parkingSpotText, carNumber, driverName, 
                    phoneNumber, isRemove);
            }
            catch (Exception)
            {

            }
        }

        public static bool Save(string command, string parkingSpot, out string contents)
        {

            DBHelper.selectQuery(int.Parse(parkingSpot));
            //out 키워드의 특징이 해당 메소드에 반드시 해당 변수의 값을 지정해야함.
            contents = "";
            if(command == "insert")
            {
                //ref = reference
                //contents 변수의 위치(메모리 상에서 어디 있는지) DBinsert나 DBdelete 안에서 contents 값 변경하기 //실제 변경됨
                //out 키워드와 유사, out키워드는 값을 바꾸는 것에 초첨을 맞춘거라면 ref는 이 변수의 위치(=주소값)을 전달하는 것에 초점을 맞춤

                //정확히 주소값이 아닌 참조값임 C#과 JAVA는 주소값 개념이 없음
                //포인터 문법처럼 주소를 쓰거나 그러진 않음
                return DBInsert(parkingSpot, ref contents);
            }
            else
            {
                return DBDelete(parkingSpot, ref contents);
            }
        }

        private static bool DBDelete(string parkingSpot, ref string contents)
        {
            if (DBHelper.dt.Rows.Count != 0)  //해당 공간이 있는 경우
            {
                DBHelper.deleteQuery(parkingSpot);
                contents = $"주차공간 {parkingSpot}이/가 삭제되었습니다.";
                return true;
            }
            else
            {
                contents = "해당 주차공간은 없는 공간입니다.";
                return false;
            }
        }

        private static bool DBInsert(string parkingSpot, ref string contents)
        {
            if (DBHelper.dt.Rows.Count == 0)
            {
                DBHelper.insertQuery(parkingSpot);
                contents = $"주차공간 {parkingSpot}이/가 추가되었습니다.";
                return true;
            }
            else
            {
                contents = "해당 주차공간이 이미 존재합니다.";
                return false;
            }
        }
    }
}
