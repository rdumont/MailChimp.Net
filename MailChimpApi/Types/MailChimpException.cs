using System;

namespace RDumont.MailChimpApi.Types
{
    public class MailChimpException : Exception
    {
        public int Code { get; private set; }

        public MailChimpException(ApiError error) : base(error.Error)
        {
            Code = error.Code;
        }
    }

    public class ApiError
    {
        public int Code { get; set; }
        public string Error { get; set; }
    }
}
