using System.Data;
using System.Data.SqlClient;

namespace Session2
{
    // implement Singelton design patterns
    internal class Connection
    {
        private SqlConnection cnx;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;

        private Connection(string cnx_str)
        {
            cnx = new SqlConnection(cnx_str);
            cmd = new SqlCommand();
            adapter = new SqlDataAdapter(cmd);
        }

        public DataTable query(string qr)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = qr;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();

            return dt;
        }

        private static Connection instance;
        public static Connection getInstance(string cnx_str)
        {
            if (instance == null)
            {
                instance = new Connection(cnx_str);

                return instance;
            } else
            {
                return instance;
            }
        }

    }
}
