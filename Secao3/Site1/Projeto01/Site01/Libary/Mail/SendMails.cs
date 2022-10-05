using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Site01.Libary.Mail
{
    public class SendMails
    {
        public static void SendMessageContact(Contato contato)
        {
            SmtpClient smtp = new SmtpClient(Constants.ServerSMTP,Constants.PortSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.User, Constants.Password);


            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("tarcisiokta2012@gmail.com");
            mailMessage.To.Add("tarcisiokta2012@gmail.com");
            mailMessage.Subject="Formulario de contato";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "<h1>Formulário de contato</h1> " + contato.ToString();

            smtp.Send(mailMessage);
        }
    }
}
