using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalstudyroomMangement
{
    public class DBseatconnect
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
        public static void PSRMngQuery(int seatNum, string uesrid, DateTime startday, DateTime endday)
        {

            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";
                sqlcommand = "update seatMng set userId = @p1 starday=@p4, endday=@p5 where seatNum = @p3";
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
    }
}
