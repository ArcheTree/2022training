using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalstudyroomMangement
{
    public class DBseatMng
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
        public static void seatMngselectQuery(int seatNum)
        {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from seatMng where seatNum=@p1";
                cmd.Parameters.AddWithValue("@p1", seatNum);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "seatMng");
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show("조건부검색");
                return;
            }
            finally
            {
                conn.Close();
            }

        }
        public static void seatupdateQuery(int seatNum, string userId, DateTime startday, DateTime endday)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";

                sqlcommand = "update seatMng set userId = @p1, startday=@p2, endday= @p3 where seatNum=@p4";
                cmd.Parameters.AddWithValue("@p1", userId);
                cmd.Parameters.AddWithValue("@p2", startday);
                cmd.Parameters.AddWithValue("@p3", endday);
                cmd.Parameters.AddWithValue("@p4", seatNum);

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
        public static void autoexpiredQuery()
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";

                sqlcommand = "update seatMng set userId =null, startday=null, endday= null where endday < CONVERT(date,GETDATE())";
             
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
