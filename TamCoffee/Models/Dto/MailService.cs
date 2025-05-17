using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace TamCoffee.Models.Dto
{
    public static class MailService
    {
        private static readonly EmailSettings _emailSettings;

        static MailService()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _emailSettings = new EmailSettings();
            config.GetSection("EmailSettings").Bind(_emailSettings);
        }

        public static bool SendEmail(string toEmail, string subject, string messageBody)
        {
            try
            {
                var fromAddress = new MailAddress(_emailSettings.FromEmail, _emailSettings.FromName);
                var toAddress = new MailAddress(toEmail);

                using (var smtp = new SmtpClient(_emailSettings.SmtpHost, _emailSettings.SmtpPort))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(_emailSettings.FromEmail, _emailSettings.FromPassword);

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = messageBody
                    })
                    {
                        smtp.Send(message);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //bool result = MailService.SendEmail("2@gmail.com", "aloaoa", "test");

        //MessageBox.Show(result? "thành côn" : "loi");
    }
}