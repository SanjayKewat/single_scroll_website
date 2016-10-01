using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using RSOFTWARESOLUTIONS.Models;

namespace RSOFTWARESOLUTIONS.Controllers
{
    public class HOMEController : Controller
    {
        //
        // GET: /HOME/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MailModel mailmodel)
        {
           
            if (ModelState.IsValid)
            {
                MailMessage message = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                MailAddress fromAddress = new MailAddress("amit.tiwari.swe@gmail.com"); //change here providing email address
                message.From = fromAddress;
                message.To.Add("amit.tiwari.swe@gmail.com"); //change here providing email address
                message.Subject = "Someone Contact you..!";
                message.Body = @"<h3><font color='31AAE1'>Follow Below Details : </font></h3><br>
                             <label>Name : </label>" + mailmodel.Name + @"<br/>
                             <label>Email Address : </label>" + mailmodel.mail_address + @"<br/>
                             <label>Phone No. : </label>" + mailmodel.Phone + @"<br/><br>
                             <label>Message : </label><br/><p>" + mailmodel.Msg + "</p><br/><br/><br/><h5>Thankyou for Contact Us...!</h5>";
                             
                message.IsBodyHtml = true;

                smtpClient.Host = "smtp.gmail.com";   // We use gmail as our smtp client
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("amit.tiwari.swe@gmail.com", "786anjali"); //change here providing email address,password goes
                smtpClient.EnableSsl = true;
                smtpClient.Send(message);
                
                TempData["notice"] = "For Contacting Us. We will contact soon..!";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}
