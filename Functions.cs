using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Functions
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public DataTable dt;
        public SqlDataAdapter da;
        public string Constr;

        public Functions()
        {
            Constr = @"Data Source=DESKTOP-086SVEJ;Initial Catalog=LMS_Project;Integrated Security=True";
            con = new SqlConnection(Constr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public DataTable GetData(String Query)
        {
            dt = new DataTable();
            da = new SqlDataAdapter(Query, con);
            da.Fill(dt);
            return dt;
        }
        public int SetData(String Query)
        {
            int Cnt = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = Query;
            Cnt = cmd.ExecuteNonQuery();
            return Cnt;
        }

    }
}
