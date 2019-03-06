using Loja.Models;
using System;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using System.Net.Mail;

namespace Loja.Controller
{
    public class ContactUsController : SurfaceController
    {

        public string GetViewPath(string name)
        {
            return $"/Views/Partials/{name}.cshtml";
        }

        [HttpGet]
        public ActionResult RenderForm(ContactUsModel model)
        {
            return PartialView(GetViewPath("ContactUs"), model);
        }
        [HttpPost]
        public ActionResult SubmitForm(ContactUsModel model)
        {
            bool success = false;
            if (ModelState.IsValid)
            {
                success = SendEmail(model);
            }

            return PartialView(GetViewPath(success ? "Success" : "Error"));
        }
        
        private bool SendEmail(ContactUsModel model)
        {
            /*
             https://msdn.microsoft.com/pt-br/library/system.net.mail.mailmessage(v=vs.100).aspx
             */

            MailMessage mail = new MailMessage();

            try
            {
                MailMessage message = new MailMessage(model.Email, "dayonne.p@gmail.com")
                {
                    Subject = string.Format("Enquiry from {0} {1}", model.Name, model.Email),
                    Body = model.Message
                };
                SmtpClient client = new System.Net.Mail.SmtpClient();
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("dayonne.p", "marcopolo123");
                mail.Sender = new System.Net.Mail.MailAddress(model.Email, model.Name);
                mail.From = new MailAddress(model.Email, model.Name);
                mail.To.Add(new MailAddress("dayonne.p@gmail.com", "Daione"));
                mail.Subject = "Contato";
                mail.Body = " Mensagem do site:<br/> Nome:  " + model.Name + "<br/> Email : " + model.Email + " <br/> Mensagem : " + model.Message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                client.Send(mail);
                return true;
            }
            catch (System.Exception erro)
            {
                View("~/Views/Partials/ErrorView.cshtml", model);
                return false;
            }
            finally
            {
                mail = null;
            }

        }
    }
}