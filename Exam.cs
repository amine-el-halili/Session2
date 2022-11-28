using System.Data;

namespace Session2
{
    class Exam
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private DateTime openedAt;
        public DateTime OpenedAt
        {
            get { return openedAt; }
            set { openedAt = value; }
        }
        private DateTime closedAt;
        public DateTime CloseedAt
        {
            get { return closedAt; }
            set { closedAt = value; }
        }
        private int duration;
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private List<Question> questions = new List<Question>();
        public Exam(string title, int duration, DateTime opened_at, DateTime closed_at)
        {
            this.title = title;
            this.duration = duration;
            this.openedAt = opened_at;
            this.closedAt = closed_at;
        }
        public void addQuestion(Question question)
        {
            questions.Add(question);
        }
        
        // save an exam at database (persistence)
        public Exam save()
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select count(*) as count from Exam where ID = " + id);

                if (int.Parse(dt.Rows[0]["count"].ToString()) == 1)
                {
                    connection.query("UPDATE EXAM SET TITLE = '" + title + "', DURATION = " + duration + ", OPENED_AT = " + openedAt + ", CLOSED_AT = " + closedAt + " WHERE ID = " + id);
                }
                else
                {
                    DataTable id_table = connection.query("INSERT INTO EXAM (TITLE, DURATION, OPENED_AT, CLOSED_AT) VALUES ('" + title + "', " + duration + ", '" + openedAt.ToUniversalTime() + "', '" + closedAt.ToUniversalTime() + "'); SELECT SCOPE_IDENTITY() as ID");
                    id = int.Parse(id_table.Rows[0]["ID"].ToString());
                }


                foreach (Question question in questions)
                {
                    question.save();
                    connection.query("INSERT INTO EXAM_QUESTION (ID_QUESTION, ID_EXAM, NOTE) VALUES (" + question.Id + ", " + id + ", " + question.Note + ")");
                }

                return this;

            } catch (Exception ex)
            {
                ErrorForm error = new ErrorForm();
                error.Controls[0].Text = ex.Message;
                error.Show();
                return null;
            }
        }

        public static List<Exam> getALl()
        {
            try
            {
                List<Exam> list = new List<Exam>();
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Exam");

                foreach (DataRow row in dt.Rows)
                {
                    string t = row["TITLE"].ToString();
                    DateTime open = DateTime.Parse(row["OPENED_AT"].ToString());
                    DateTime close = DateTime.Parse(row["CLOSED_AT"].ToString());
                    int d = int.Parse(row["DURATION"].ToString());

                    Exam exam = new Exam(t, d, open, close);
                    list.Add(exam);
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

        public static Exam getById(int _id)
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Exam where id = " + _id);

                if (dt.Rows.Count == 0) return null;


                string t = dt.Rows[0]["TITLE"].ToString();
                DateTime open = DateTime.Parse(dt.Rows[0]["OPENED_AT"].ToString());
                DateTime close = DateTime.Parse(dt.Rows[0]["CLOSED_AT"].ToString());
                int d = int.Parse(dt.Rows[0]["DURATION"].ToString());

                return new Exam(t, d, open, close);
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
