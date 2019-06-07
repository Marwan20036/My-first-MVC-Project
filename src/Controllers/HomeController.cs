namespace MarwanWeb.Controllers
{
    using MarwanWeb.Models;
    using System.Net.Mail;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact
            (
                ContactViewModel model
            )
        {
            var client = new SmtpClient();

            var body = $"From: {model.Email}\nMessage: {model.Message}";

            var message = new MailMessage
            (
                "marwan.al.alatoum20036@gmail.com",
                "marwan.al.alatoum20036@gmail.com",
                model.Subject,
                body
            );

            client.Send(message);

            return View(model);
        }
    }
}
