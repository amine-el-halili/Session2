using System.Data;
using System.Data.SqlClient;

namespace Session2
{
    internal class Connection
    {
        private static string str;

        private static SqlConnection cnx;
        private static SqlCommand cmd;
        private static SqlDataAdapter adapter;

        public static void init(string cnx_str)
        {
            str = cnx_str;
            SqlConnection cnx = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        }

        public static DataTable query(string qr)
        {

            cnx.Open();
            cmd.CommandText = str;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();

            return dt;
        }

    }
}
