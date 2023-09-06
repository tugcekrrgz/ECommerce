using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Common
{
    public class MailSender
    {
        public static void SendEmail(string email, string subject, string body)
        {
            //Outlook   
            //Mail Message
            MailMessage message = new MailMessage();
            message.From = new MailAddress("bilgeadamtugce@outlook.com","Bilge Adam Tuğçe");
            message.Subject = subject;
            message.Body = body;
            message.BodyEncoding = Encoding.UTF8;
            message.To.Add(email);

            //Smtp Protololü 
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("bilgeadamtugce@outlook.com", "Tugce34.,");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.EnableSsl = true;

            smtpClient.Send(message);
            

            /*
            //Gmail için - Olmadı!
            //Mail Message
            MailMessage message = new MailMessage();
            message.From = new MailAddress("bilgeadamtugce@gmail.com","Bilge Adam Tuğçe");
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;
            message.BodyEncoding = Encoding.UTF8;
            message.To.Add(email);
            NetworkCredential loginInfo = new NetworkCredential("bilgeadamtugce@gmail.com", "Tugce34.,");

            //Smtp Protololü 
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = loginInfo;
            /*smtpClient.Port = 465;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            
            smtpClient.Send(message);
            */
        }
    }
}
