using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                "local", "PSRMngDB", "SSPI"); //학원에서는 PSRMngDB  로 연결해야함
                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
        }
        public static void userselectQuery()
        {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                
                cmd.CommandText = "select * from UserId";
               
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
       
        
        public static void useridupdateQuery(string userId, string name, string phone, DateTime birth, DateTime registrationDay)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";

                    sqlcommand = "update Registration set userId=@p1, " +
                        "name=@p2, phone=@p3," +
                        "birth=@p4 where userId=@p8";

                    cmd.Parameters.AddWithValue("@p1", userId);
                    cmd.Parameters.AddWithValue("@p2", name);
                    cmd.Parameters.AddWithValue("@p3", phone);
                    cmd.Parameters.AddWithValue("@p4",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p8", userId);
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
        //insert -> 자리, 등록정보 2군데 들어가도록(따로 할건지 같이 할건지)
        //자동 delet -> 날짜가 지나면 자동 삭제
        

 
        public static void newbeQuery(string userId, string name, string phone, DateTime birth, DateTime registerationDay)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";
                sqlcommand = "insert into UserId values(@p1, @p2, @p3, @p4, @p5)";
                cmd.Parameters.AddWithValue("@p1", userId);
                cmd.Parameters.AddWithValue("@p2", name);
                cmd.Parameters.AddWithValue("@p3", phone);
                cmd.Parameters.AddWithValue("@p4", birth);
                cmd.Parameters.AddWithValue("@p5", registerationDay); 
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
        public static void expiredseatQuery(int seatNum)
        {

            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";
                sqlcommand = "update Registration set userId='', " +
                        "startday='', endday=null, Description=null where seatNum=@p3";
                cmd.Parameters.AddWithValue("@p3", seatNum);
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

        public static void modifiUserQuery(string userId, string name, string phone)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";
                sqlcommand = "update UserId set name=@p1, " + "phone=@p2 where userId=@p3";
                cmd.Parameters.AddWithValue("@p1", name);
                cmd.Parameters.AddWithValue("@p2", phone);
                cmd.Parameters.AddWithValue("@p3", userId);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
