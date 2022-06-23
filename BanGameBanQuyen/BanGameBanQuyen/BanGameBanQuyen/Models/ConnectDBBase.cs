using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace BanGameBanQuyen.Models
{
    public class ConnectDBBase
    {

        SqlConnection conn;
        public void Close(SqlConnection conn)
        {
            try
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
            }
        }
        public SqlConnection Connect(SqlConnection conn)
        {


            string nameSever = @"DESKTOP-VDOKHFC\SQLEXPRESS2K19";
            string database = "PetShop";
            string user = "";
            string pass = "";
            string stringConnect = "Data Source=.\\SQLEXPRESS2K19;Initial Catalog=BanGameBanQuyen;Integrated Security=True" + nameSever + ";Initial Catalog=" + database + ";Integrated Security=SSPI;User ID=" + user + ";Password=" + pass + ";";

            conn = new SqlConnection(stringConnect);
            return conn;
        }

        public void Open(SqlConnection conn)
        {
            try
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }
        public DataTable SelectTable(string table)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            conn = Connect(conn);
            SqlCommand cmd = new SqlCommand("SelectAllTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@table", table);
            Open(conn);

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Close(conn);
            return dt;
        }
    }
}