using System.Data;
using System.Data.SqlClient;

namespace Session2
{
    internal class Model
    {
        private string str;

        private SqlConnection cnx;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;

        public Model(string str)
        {
            this.str = str;
            SqlConnection cnx = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        }


    }
}
