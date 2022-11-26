namespace Session2
{
    class Response
    {
        private int id { get; set; }
        private Question question { get; set; }
        private float score { get; set; }
        private List<string> answers;

        void addAnswer(string ans)
        {
            answers.Add(ans);
        }
    }
}
