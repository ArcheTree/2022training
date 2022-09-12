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

                else //특정 날
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
        public static void seatMngselectQuery()
        {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                
                    cmd.CommandText = "select * from seatMng";
               

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "seatMng");
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
        public static void registerupdateQuery(int registerNum, string uesrid, int roomNum,
            int seatNum, DateTime endday, string Description, bool isRefund, DateTime refundDay, int refundpay) 
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";

                if (isRefund) //환불
                {
                    sqlcommand = "update Registration set endday="+ refundDay + " =@p2, Description='환불'=@p3, refundpay = " + refundpay + "원 = @p4  where registerNum=@p1";
                    cmd.Parameters.AddWithValue("@p1", registerNum);
                    cmd.Parameters.AddWithValue("@p2", endday);
                    cmd.Parameters.AddWithValue("@p3", Description);
                    cmd.Parameters.AddWithValue("@p4", refundpay);
                }
                else //자리변경
                {
                    sqlcommand = "update Registration set roomNum=@p2, seatNum=@p3," +
                        "Description=@7 where registerNum=@p8";

                    cmd.Parameters.AddWithValue("@p1", uesrid);
                    cmd.Parameters.AddWithValue("@p2", roomNum);
                    cmd.Parameters.AddWithValue("@p3", seatNum);
                    cmd.Parameters.AddWithValue("@p7", Description);
                    cmd.Parameters.AddWithValue("@p8", registerNum);
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
        public static void PSRMngQuery(int seatNum,  string uesrid, DateTime startday, DateTime endday)
        {

            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";
                sqlcommand = "update Mngseat set userId = @p1 starday=@p4, endday=@p5 where seatNum = @p3";
                cmd.Parameters.AddWithValue("@p1", uesrid);
                cmd.Parameters.AddWithValue("@p3", seatNum);
                cmd.Parameters.AddWithValue("@p4", startday); ;
                cmd.Parameters.AddWithValue("@p5", endday); ;
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
        public static void newinsertQuery(string uesrid, int roomNum, int seatNum, DateTime startday, DateTime endday, int pay, string Description)
        {
           
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";
                sqlcommand = "insert into Registration values(NEXT VALUE FOR dbo.PSRMngDB, @p1, @p2, @p3, @p4, @p5,  @p7, @8,'')";
                cmd.Parameters.AddWithValue("@p1", uesrid);
                cmd.Parameters.AddWithValue("@p2", roomNum);
                cmd.Parameters.AddWithValue("@p3", seatNum);
                cmd.Parameters.AddWithValue("@p4", startday);
                cmd.Parameters.AddWithValue("@p5", endday); ;
                cmd.Parameters.AddWithValue("@p7", pay);
                cmd.Parameters.AddWithValue("@p8", Description);
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

        public static void dayselectQuerty(DateTime onday, DateTime overday)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";
                sqlcommand = "select * from Registeration where takeday BETWEEN '@p1' AND '@p2'";
                cmd.Parameters.AddWithValue("@p1", onday);
                cmd.Parameters.AddWithValue("@p2", overday);
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


    }
}
