namespace Session2
{
    class Mcq : Question
    {
        private List<Suggestion> items;
        public void addSuggestion(Suggestion sg)
        {
            items.Add(sg);
        }
    }
}
