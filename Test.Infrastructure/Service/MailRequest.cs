using Microsoft.AspNetCore.Http;

namespace Test.Infrastructure.Service
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
     }
}