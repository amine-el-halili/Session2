namespace Session2
{
    class Mcq : Question
    {
        private List<Suggestion> items;
        private int initialScore { get; set; }

        public Mcq(int score)
        {
            initialScore = score;
        }
        public void addSuggestion(Suggestion sg)
        {
            items.Add(sg);
        }
    }
}
