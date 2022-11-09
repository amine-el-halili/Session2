namespace Session2
{
    class Exam
    {
        private string id;
        private string title;
        private DateTime openedAt;
        private int duration;
        private List<Question> questionsList;
        public void addQuestion(Question question)
        {
            questionsList.Add(question);
        }
        
    }
}
