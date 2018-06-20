using Loja.Models;
using System;
using System.Web.Mvc; 
using Umbraco.Web.Mvc;
using System.Net.Mail; 

namespace Loja.Controller
{
    public class ContactUsController : SurfaceController
    {
        public const string PARTIAL_VIEW_CONTACT_US  = "~/Views/Partials/";
        public ActionResult RenderForm(ContactUsModel model)
        {
            return PartialView(PARTIAL_VIEW_CONTACT_US + "ContactUs.cshtml");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ContactUsModel model)
        {

            if (ModelState.IsValid)
            {
                SendEmail(model);
                return RedirectToCurrentUmbracoPage(); 
            }
            return CurrentUmbracoPage();
        }

        private void SendEmail(ContactUsModel model)
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
            }
            catch (System.Exception erro)
            {
                 
                View("~/Views/Partials/ErrorView.cshtml", model);
            }
            finally
            {
                mail = null;
            }
          

        }
    }
}