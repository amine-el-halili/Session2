using System.Data;

namespace Session2
{
    class OpenQuestion: Question
    {
        public OpenQuestion(string stmt): base(_statement: stmt) { }    

        public override Question save()
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select count(*) as count from Question where ID = " + id);

                if (int.Parse(dt.Rows[0]["count"].ToString()) == 1)
                {
                    connection.query("UPDATE Question SET STATEMENT = '" + statement + "'" + " WHERE ID = " + id);
                }
                else
                {
                    DataTable id_table = connection.query("INSERT INTO Question (STATEMENT, TYPE) VALUES ('" + statement + "', 'open'); SELECT SCOPE_IDENTITY() as ID");
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

        public static List<OpenQuestion> getAll()
        {
            try
            {
                List<OpenQuestion> list = new List<OpenQuestion>();
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Question where type = 'open'");
                foreach (DataRow row in dt.Rows)
                {
                    string stmt = row["STATEMENT"].ToString();
                    OpenQuestion openQuestion = new OpenQuestion(stmt);
                    openQuestion.Id = int.Parse(row["ID"].ToString());
                    list.Add(openQuestion);
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

        public static OpenQuestion getById(int _id)
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Question Where ID = " + _id.ToString() + "and type = 'open'");

                if (dt.Rows.Count == 0) return null;


                string stmt = dt.Rows[0]["STATEMENT"].ToString();
                OpenQuestion question = new OpenQuestion(stmt);
                question.Id = int.Parse(dt.Rows[0]["ID"].ToString());

                return question;
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
