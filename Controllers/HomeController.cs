using kCab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace kCab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public  ActionResult Contact(ContactUsModel model)
        {
            if(ModelState.IsValid)
            {
                EmailController controller = new EmailController();
                controller.SendEmail(model.Email, model.Subject, model.Message);
               
            }
            ViewBag.Message = "Your contact page.";
            return View();

        }
        
    }
}