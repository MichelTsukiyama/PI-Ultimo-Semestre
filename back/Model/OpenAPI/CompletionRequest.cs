namespace back.Model.OpenAPI
{
    public class CompletionRequest
    {
        public CompletionRequest(string content)
        {
            model = "gpt-3.5-turbo";
            messages = new List<Message>();

            messages.Add(new Message 
            {
                role = "user",
                content = content
            });
        }

        public string model { get; set; }
        public List<Message> messages { get; set; }
    }
}