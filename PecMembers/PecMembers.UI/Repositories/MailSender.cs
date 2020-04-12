using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace PecMembers.UI.Services
{
    public static class MailSender
    {
        public static void Sender(string Server, int Port, string Username, string Password, string toMail, string subject, string text)
        {

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(Username);
                mail.To.Add(toMail);
                mail.Subject = subject;
                mail.Body = text;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(Server, Port))
                {
                    smtp.Credentials = new System.Net.NetworkCredential(Username, Password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                }


            }
        }

    }
}