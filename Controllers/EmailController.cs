using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace kCab.Controllers
{
    public class EmailController
    {
        public void SendEmail(string email, string subject,string message)
        {
            //Send Email
            MailMessage Msg = new MailMessage();
            try
            {
                Msg.From = new MailAddress(ConfigurationManager.AppSettings["Email"].ToString());// Sender details here, replace with valid value
                Msg.Subject = subject; // subject of email
                Msg.To.Add(email); //Add Email id, to which we will send email
                Msg.Body = message;
                Msg.IsBodyHtml = true;
                Msg.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false; // to get rid of error "SMTP server requires a secure connection"
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["Email"].ToString(),
                    ConfigurationManager.AppSettings["Password"].ToString());
                smtp.Credentials = credentials;
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;

                smtp.Send(Msg);
                //Response.Write("<script>alert('Submitted Successfully');</script>");
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
    }
}
