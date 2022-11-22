namespace Session2
{
    class Qcm : Question
    {
        private List<Suggestion> suggestions;
        private float initialScore { get; set; }

        public Qcm(float score)
        {
            initialScore = score;
        }
        public void addSuggestion(Suggestion sg)
        {
            suggestions.Add(sg);
        }
        
    }
}
