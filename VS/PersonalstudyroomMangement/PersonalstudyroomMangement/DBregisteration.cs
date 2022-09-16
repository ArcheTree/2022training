using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace PersonalstudyroomMangement
{
    public class DBregisteration
    {
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void ConnectreDB()
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

        public static void registerselectQuery(DateTime onday, DateTime overday)
        {
            try
            {
                ConnectreDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Registeration where takeday between @p1 and @p2 order by registerNum";
                
                cmd.Parameters.AddWithValue("@p1", onday);
                cmd.Parameters.AddWithValue("@p2", overday);
           
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Registeration");
                dt = ds.Tables[0];

            }
            catch (Exception )
            {
                System.Windows.Forms.MessageBox.Show("select 실패");
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void countQuery()
        {
            try
            {
                ConnectreDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Registeration where endday between CONVERT(date,GETDATE()) AND CONVERT(date,GETDATE()+7)";

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Registeration");
                dt = ds.Tables[0];

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("select 실패");
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
                ConnectreDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from Registeration where endday >= CONVERT(date,GETDATE()) order by endday";
             

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Registeration");
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
        public static void searchQuery(string Query, string view)
        {
            try
            {
                ConnectreDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if(Query == "roomNum")
                {
                cmd.CommandText = "select roomNum, seatNum, userId, startday, endday from Registeration where endday >= CONVERT(date,GETDATE()) AND roomNum = @p1";
                }
                else if (Query == "userId")
                {
                cmd.CommandText = "select roomNum, seatNum, userId, startday, endday from Registeration where endday >= CONVERT(date,GETDATE()) AND userId = @p1";
                }
                else if (Query == "seatNum")
                {
                cmd.CommandText = "select roomNum, seatNum, userId, startday, endday from Registeration where endday >= CONVERT(date,GETDATE()) AND seatNum = @p1";
                }

                cmd.Parameters.AddWithValue("@p1", view);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Registeration");
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
        public static void registerupdateQuery(int registerNum, string uesrid, int roomNum,
           int seatNum, DateTime endday, string Description, bool isRefund, DateTime refundDay, int refundpay)
        {
            try
            {
                ConnectreDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";

                if (isRefund) //환불
                {
                    sqlcommand = "update Registration set endday=" + refundDay + " =@p2, Description='환불'=@p3, refundpay = " + refundpay + "원 = @p4  where registerNum=@p1";
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
     
        public static void newinsertQuery(string uesrid, int roomNum, int seatNum, DateTime takeday, DateTime startday, DateTime endday, int pay, string Description)
        {
            try
            {
                ConnectreDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand = "";
                sqlcommand = "insert into Registeration values(NEXT VALUE FOR dbo.PSRMngDB, @p1, @p2, @p3, @p6, @p7, @p4, @p5, null, 0)";
                cmd.Parameters.AddWithValue("@p1", uesrid);
                cmd.Parameters.AddWithValue("@p2", roomNum);
                cmd.Parameters.AddWithValue("@p3", seatNum);
                cmd.Parameters.AddWithValue("@p4", startday);
                cmd.Parameters.AddWithValue("@p5", endday); ;
                cmd.Parameters.AddWithValue("@p6", takeday);
                cmd.Parameters.AddWithValue("@p7", pay);
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
