using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minas
{
    // Controller Connection
    internal class Connection
    {
       private static string connectionString = "server= localhost ;database=minasDB;Integrated Security=True";
       private SqlConnection usingConn = new SqlConnection(connectionString);
        
        public void InsertData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, usingConn);
       //     cmd.CommandText = sql;
            usingConn.Open();
            cmd.ExecuteNonQuery();
            usingConn.Close();
         
        }

        public DataTable SelectData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, usingConn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
      //      usingConn.Open();
      //      cmd.ExecuteNonQuery();
      //      usingConn.Close();
            return tabla;
        }
    }
}
