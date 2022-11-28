using System.Data;

namespace Session2
{
    class Qcm : Question
    {
        private List<Suggestion> suggestions = new List<Suggestion>();

        private float initialScore;
        public float InitialScore { get; set; }

        public Qcm(string stmt, float score) : base(stmt)
        {
            initialScore = score;
        }
        public void add(Suggestion suggestion)
        {
            suggestions.Add(suggestion);
        }
        public override Question save()
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select count(*) as count from Question where ID = " + id);

                if (int.Parse(dt.Rows[0]["count"].ToString()) == 1)
                {
                    connection.query("UPDATE Question SET STATEMENT = '" + statement + "', INITIAL_SCORE = " + note + " WHERE ID = " + id);
                }
                else
                {
                    DataTable id_table = connection.query("INSERT INTO Question (STATEMENT, TYPE, INITIAL_SCORE) VALUES ('" + statement + "', 'qcm', " + initialScore + "); SELECT SCOPE_IDENTITY() as ID");
                    id = int.Parse(id_table.Rows[0]["ID"].ToString());
                }

                foreach (Suggestion suggestion in suggestions)
                {
                    Suggestion s = suggestion.save();
                    connection.query("INSERT INTO QUESTION_SUGGESTION (ID_QUESTION, ID_SUGGESTION, COEF) VALUES (" + id + ", " + s.Id + ", " + s.Coef + ")");
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

        public static List<Qcm> getALl()
        {
            try
            {
                List<Qcm> list = new List<Qcm>();
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Question where type = 'qcm'");
                foreach (DataRow row in dt.Rows)
                {
                    string stmt = row["STATEMENT"].ToString();
                    float _note = float.Parse(row["INITIAL_SCORE"].ToString());
                    Qcm qcm = new Qcm(stmt, _note);
                    list.Add(qcm);
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

        public static Qcm getByID(int _id)
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Question Where ID = " + _id + "and type = 'qcm'");

                if (dt.Rows.Count == 0) return null;

                string stmt = dt.Rows[0]["STATEMENT"].ToString();
                float _note = float.Parse(dt.Rows[0]["INITIAL_SCORE"].ToString());

                Qcm question = new Qcm(stmt, _note);
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
