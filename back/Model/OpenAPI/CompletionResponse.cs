namespace back.Model.OpenAPI
{
    public class CompletionResponse
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public int Created { get; set; }
        public string Model { get; set; }
        public Usage Usage { get; set; }
        public List<Choice> Choices { get; set; }
    }

     public class Choice
    {
        public Message Message { get; set; }
        public string Finish_reason { get; set; }
        public int Index { get; set; }
    }

    public class Usage
    {
        public int Prompt_tokens { get; set; }
        public int Completion_tokens { get; set; }
        public int Total_tokens { get; set; }
    }
}