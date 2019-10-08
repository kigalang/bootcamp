 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace formDemo.Controllers
{
    public class FormController : Controller
    {

        // GET: Form
        public ActionResult Index()
        {
            return View();
        }


        //Weakly typed synchronous form
        [HttpPost]
        public ActionResult FormOne(string textBoxStringData, int textBoxIntData, string checkboxData)
        {
            //redirects to a new page after receiving the form's values
            return RedirectToAction("NewPage");
        }


       
        // Called by FormOne 
        public ActionResult NewPage()
        {
            return View();
        }
    }
}

Pricing
API
Training
Blog
About
