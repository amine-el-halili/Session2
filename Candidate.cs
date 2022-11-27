using System.Data;

namespace Session2
{
    class Candidate
    {   
        private int id;
        public int Id {
            get { return id; }
            set { id = value; }
         }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Candidate(string name)
        {
            this.name = name;
        }
        public void save()
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select count(*) as count from Candidat where ID = " + id);

                if (int.Parse(dt.Rows[0]["count"].ToString()) == 1)
                {
                    connection.query("UPDATE CANDIDAT SET NAME = '" + name + "' WHERE ID = " + id);
                }
                else
                {
                    connection.query("INSERT INTO CANDIDAT (NAME) VALUES ('" + name + "');");
                }
            } catch (Exception ex)
            {
                ErrorForm error = new ErrorForm();
                error.Controls[0].Text = ex.Message;
                error.Show();
            }
        }

        public static List<Candidate> getAll()
        {
            try
            {
                List<Candidate> list = new List<Candidate>();
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Candidat");
                foreach (DataRow row in dt.Rows)
                {
                    string _name = row["NAME"].ToString();
                    Candidate candidate = new Candidate(_name);
                    candidate.Id = int.Parse(row["ID"].ToString());

                    list.Add(candidate);
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

        public static Candidate getById(int _id)
        {
            try
            {
                Connection connection = Connection.getInstance(@"Data Source=ELHALILI\SQLEXPRESS;Initial Catalog=EXAMINATION;Integrated Security=True");
                DataTable dt = connection.query("Select * from Candidat Where ID = " + _id.ToString());

                Candidate candidate = new Candidate(dt.Rows[0]["NAME"].ToString());
                candidate.Id = int.Parse(dt.Rows[0]["ID"].ToString());

                return candidate;
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
