using kCab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dataibrary;




namespace kCab.Controllers
{
    public class AgentAdminController : Controller
    {
        // GET: Agent
        public ActionResult SignUp()
        {
            return View();
        }

        //POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(AgentAdminModel model)
        {
            if(ModelState.IsValid)
            {
                  
                return RedirectToAction("Index"); //redirect to homepage if model state is valid
            }
            return View();
        }
    }
}