using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace StudentDataAccessLayer
{
    public class DBContext
    {
        public static DataTable Select(string command)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI"].ConnectionString);
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt;
        }

        public static int DMLCommand(string command, SqlParameter[] parameters ) 
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI"].ConnectionString);
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.Parameters.AddRange(parameters);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;

        }
    }
}
