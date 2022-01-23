using kCab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.Logic.AdminProcessor;

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
               int recordsCreated= CreateAdmin(model.AdminId,model.Name, model.LastName, model.PhoneNumber, model.EmailAddress);
                    {

                    }

                return RedirectToAction("Index"); //redirect to homepage if model state is valid
            }
            return View();
        }
    }
}