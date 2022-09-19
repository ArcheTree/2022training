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
        public static void seatMngselectQuery()
        {
            try
            {
                ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from seatMng order by seatNum";


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
    }
}
