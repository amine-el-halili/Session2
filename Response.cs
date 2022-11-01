using System.Collections;
namespace Session2
{
    class Response
    {
        private Question question;
        // if mcq check numbers else the only first element will be checked
        private ArrayList answer;
        private Boolean isMcq;

        public void addAnswer(Object ans)
        {
            answer.Add(ans);
        }
    }
}
