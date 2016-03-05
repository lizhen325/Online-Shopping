using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace UI.Common
{
    public class SendMail
    {
        public bool Send(string MessageFrom, string MessageTo, string MessageSubject, string MessageBody)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("zhenli336@gmail.com", "Flwls3250");
            MailMessage msg = new MailMessage();
            msg.To.Add(MessageTo);
            msg.From = new MailAddress(MessageFrom);
            msg.Subject = MessageSubject;
            msg.Body = MessageBody;
            msg.IsBodyHtml = true;
            try
            {
                client.Send(msg);

            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}