 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using formDemo.Models;

namespace formDemo.Controllers
{
    public class FormController : Controller
    {

        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(string textBoxStringData, int textBoxIntData, bool checkboxData)
        {
           /* FormData data = new FormData();
            data.TextBoxStringData = textBoxStringData; */
           
            //redirects to a new page after receiving the form's values
            return RedirectToAction("NewPage");
        }


        public ActionResult NewPage()
        {
            return View();
        }
    }
}

