using System.Net;
namespace TamCoffee.Models.Dto
{
    public class EmailSettings
    {
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string FromPassword { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }

    }
}