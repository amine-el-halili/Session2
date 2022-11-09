namespace Session2
{
    class ExamPaper
    {
        private Candidate candidate;
        private Exam exam;
        private List<Response> responses;
        private int totalScore;

        public ExamPaper(Candidate candidate, Exam exam)
        {
            this.candidate = candidate;
            this.exam = exam;
            this.responses = new List<Response>();
            this.totalScore = 0;
        }
        public void addResponse(Response res)
        {
            responses.Add(res);
        }

        public void scoreCalcul(Func<string, int> getQuestion)
        {
            foreach (Response res in responses)
            {
                if (res.question is OpenQuestion)
                {
                    totalScore += getQuestion(res.question.statement);
                } else
                {
                    totalScore += res.question.initialScore;


                }
            }
        }
    }
}
