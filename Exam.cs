namespace Session2
{
    class Exam
    {
        private string id { get; set; }
        private string title { get; set; }
        private DateTime openedAt { get; set; }
        public DateTime closedAt { get; set; }
        private int duration { get; set; }
        private List<Question> questions;
        public void addQuestion(Question question)
        {
            questions.Add(question);
        }
        
        // save an exam at database (persistence)
        public bool save()
        {
            try
            {
                throw new NotImplementedException();

            } catch (Exception ex)
            {
                var pop = new Form();
                pop.Text = "Error";
                pop.BackColor = Color.Red;
                var label = new Label();
                label.Text = ex.Message;
                pop.Controls.Add(label);
                pop.Show();
                return false;
            }
        }
    }
}
