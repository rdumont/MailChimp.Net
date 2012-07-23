namespace RDumont.MailChimpApi.Types
{
    public class BatchSubscribeError
    {
        public string Email { get; set; }

        public int Code { get; set; }

        public string Message { get; set; }
    }
}