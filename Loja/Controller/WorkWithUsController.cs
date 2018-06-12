using Loja.Models;
using System;
using System.Web.Mvc; 
using Umbraco.Web.Mvc;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Collections.Generic;

namespace Loja.Controller
{
    public class WorkWithUsController : SurfaceController
    {
        public ActionResult RenderForm(WorkWithUsModel model)
        {
            return PartialView("~/Views/Partials/WorkWithUsP.cshtml", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(WorkWithUsModel model)
        {

            if (ModelState.IsValid)
            {
                SendEmail(model);
                return RedirectToCurrentUmbracoPage(); 
            }
            return CurrentUmbracoPage();
        }

        private void SendEmail(WorkWithUsModel model)
        {
            /*
             https://msdn.microsoft.com/pt-br/library/system.net.mail.mailmessage(v=vs.100).aspx

             */

                MailMessage mail = new MailMessage();

            try
            {
                MailMessage message = new MailMessage(model.Email, "dayonne.p@gmail.com");
                List<Stream> streams = new List<Stream>();


                message.Subject = string.Format("Enquiry from {0} {1}", model.Name, model.Email, model.Description);
                message.Body = model.Description; 
                SmtpClient client = new System.Net.Mail.SmtpClient();
                mail.Sender = new System.Net.Mail.MailAddress(model.Email, model.Name);
                mail.From = new MailAddress(model.Email, model.Name);
                mail.To.Add(new MailAddress("dayonne.p@gmail.com", "Daione"));
                mail.Subject = "Contato";
                mail.Body = " Mensagem do site:<br/> Nome:  " + model.Name + "<br/> Email : " + model.Email + " <br/>  Descrição" + model.Description;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                client.Send(mail);
            }
            catch (Exception e)
            {
                   RedirectToAction("~/Views/Partials/ErrorView.cshtml", model);

            }
            finally
            {
                mail = null;
            }
          

        }
    }
}