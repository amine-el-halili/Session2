using System.Data;

namespace Session2
{
    class Suggestion
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string statement;
        public string Statement
        {
            get { return statement; }
            set { statement = value; }
        }
        private float coef;
        public float Coef
        {
            get { return coef; }
            set { coef = value; }
        }
        public Suggestion(string _statement)
        {
            this.statement = _statement;
        }
        public Suggestion save()
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select count(*) as count from Suggestion where ID = " + id);

                if (int.Parse(dt.Rows[0]["count"].ToString()) == 1)
                {
                    connection.query("UPDATE SUGGESTION SET STATEMENT = '" + statement + "' WHERE ID = " + id);
                }
                else
                {
                    DataTable id_table = connection.query("INSERT INTO SUGGESTION (STATEMENT) VALUES ('" + statement + "'); SELECT SCOPE_IDENTITY() as ID");
                    id = int.Parse(id_table.Rows[0]["ID"].ToString());
                }

                return this;
            }
            catch (Exception ex)
            {
                ErrorForm error = new ErrorForm();
                error.Controls[0].Text = ex.Message;
                error.Show();
                return null;
            }
        }

        public static List<Suggestion> getAll()
        {
            try
            {
                List<Suggestion> list = new List<Suggestion>();
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Suggestion");
                foreach (DataRow row in dt.Rows)
                {
                    string _statetment = row["STATEMENT"].ToString();
                    Suggestion suggestion = new Suggestion(_statetment);
                    suggestion.Id = int.Parse(row["ID"].ToString());

                    list.Add(suggestion);
                }

                return list;
            }
            catch (Exception ex)
            {
                ErrorForm error = new ErrorForm();
                error.Controls[0].Text = ex.Message;
                error.Show();

                return null;
            }
        }

        public static Suggestion getById(int _id)
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Suggestion Where ID = " + _id.ToString());

                if (dt.Rows.Count == 0) return null;


                Suggestion suggestion = new Suggestion(dt.Rows[0]["STATEMENT"].ToString());
                suggestion.Id = int.Parse(dt.Rows[0]["ID"].ToString());

                return suggestion;
            }
            catch (Exception ex)
            {
                ErrorForm error = new ErrorForm();
                error.Controls[0].Text = ex.Message;
                error.Show();

                return null;
            }
        }
    }
}
