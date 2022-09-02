using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalstudyroomMangement
{
    public class DBconnect
    {
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void ConnectDB()
        {
            conn.ConnectionString =
                string.Format("Data Source=({0}); "
                + "initial Catalog = {1};" +
                "integrated Security = {2};" +
                "Timeout=3",
                "local", "PSRMngDB", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }
        public static void registerselectQuery(DateTime takeday)
        {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (takeday == null) //매개변수 없이 selectQuery 실행
                {
                    cmd.CommandText = "select * from Registration";
                }
                else //그게 아닌 경우는 특정 주차 공간 번호의 정보 조회
                {
                    cmd.CommandText = "select * from Registration " +
                        " where  = takeDay "
                        + takeday;
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Registration");
                dt = ds.Tables[0];

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void userselectQuery(string userId)
        {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (userId == null) //매개변수 없이 selectQuery 실행
                {
                    cmd.CommandText = "select * from UserId";
                }
                else //그게 아닌 경우는 특정 주차 공간 번호의 정보 조회
                {
                    cmd.CommandText = "select * from UserId " +
                        " where  = userId "
                        + userId;
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "UserId");
                dt = ds.Tables[0];

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void registerupdateQuery(string uesrid, int roomNum, int seatNum, DateTime takeDay, int pay ,DateTime startday, DateTime endday, string Description, bool isRemove)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";

                if (isRemove) //출차
                {
                    sqlcommand = "update Registration set uesrid='', " +
                        "roomNum='', seatNum='', takeDay=null where parkingspot=@p1";
                    cmd.Parameters.AddWithValue("@p1", parkingSpotText);
                }
                else
                {
                    //파라메터를 @에 실어서 보내는 방식
                    //sql injection이라는 해킹 공격 방지하는 것
                    //sql injection(sql삽입공격)은 해킹 공격의 일종
                    //커멘드에 잘못된 명령어 입력해서 비밀번호 등 탈취하는 기술
                    //ex : select * from `  <- 이렇게 말도 안 되는 문자를 입력해서
                    //비밀번호 등 정보 탈취
                    sqlcommand = "update parkingManager set carnumber=@p1, " +
                        "drivername=@p2, phonenumber=@p3," +
                        "parkingtime=@p4 where parkingspot=@p5";

                    cmd.Parameters.AddWithValue("@p1", carNumber);
                    cmd.Parameters.AddWithValue("@p2", driverName);
                    cmd.Parameters.AddWithValue("@p3", phoneNumber);
                    cmd.Parameters.AddWithValue("@p4",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", parkingSpotText);
                }
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
