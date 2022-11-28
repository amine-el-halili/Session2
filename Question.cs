namespace Session2
{
    abstract class Question
    {
        protected int id
        {
            get;
            set;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        protected string statement
        {
            get;
            set;
        }
        public string Statement
        {
            get { return statement; }
            set { statement = value; }
        }
        protected float note
        {
            get;
            set;
        }
        public float Note
        {
            get { return note; }
            set { note = value; }
        }
        public Question(string _statement)
        {
            this.statement = _statement;
        }
        public abstract Question save();

    }
}
