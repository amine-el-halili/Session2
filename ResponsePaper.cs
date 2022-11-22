namespace Session2
{
    class ResponsePaper
    {
        private Candidate candidate { get; set; }
        private Exam exam { get; set; }
        private List<Response> responses;

        public void addResponse(Response response)
        {
            responses.Add(response);
        }
    }
}
