using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace DataAccesA.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }
        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void sendMail(string subject, string body, List<string> recipientMail, bool isHtml = false)
        {
            var mailMesssage = new MailMessage();

            mailMesssage.From = new MailAddress(senderMail);
            foreach (string mail in recipientMail)
            {
                mailMesssage.To.Add(mail);
            }
            mailMesssage.Subject = subject;
            mailMesssage.IsBodyHtml = isHtml;
            mailMesssage.Body = body;
            mailMesssage.Priority = MailPriority.Normal;

            smtpClient.Send(mailMesssage);

            mailMesssage.Dispose();
            smtpClient.Dispose();


        }

    }
}
