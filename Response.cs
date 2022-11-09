using System.Collections;
namespace Session2
{
    class Response
    {
        private Question question
        {
            get { return question; }
        }
        private int score;
        private List<string> answers
        {
            get { return answers; }
        }

        void addAnswer(Object ans)
        {
            if (question is Mcq)
            {
                answers.Add(ans);
            }
            else
            {
                answers.Insert(0, ans);
            }
        }
    }
}
