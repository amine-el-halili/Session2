namespace Session2
{
    class Exam
    {
        private string id { get; set; }
        private string title { get; set; }
        private DateTime openedAt { get; set; }
        private int duration { get; set; }
        private List<Question> questions;
        public void addQuestion(Question question)
        {
            questions.Add(question);
        }
        
    }
}
