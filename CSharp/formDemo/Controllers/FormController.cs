 
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

        // Show the default index page view
        public ActionResult Index()
        {
            return View(); 
        }

        //Insert submitted data into database

        [HttpPost]
        public ActionResult Submit(string textBoxStringData)
        {
                                  
            FORMDBContext context = new FORMDBContext();
            Lists newObject = new Lists() {
                ListData = textBoxStringData,
                ListTime = DateTime.Now
            };

            context.Lists.Add(newObject);
            context.SaveChanges();
            return RedirectToAction("ConfirmationPage");            
        }

        //Show confirmation that the data was inserted into DB
        public ActionResult ConfirmationPage()
        {
            return View();
        }

        //List the contents of the database
        public ActionResult Show()

        {
            FORMDBContext context = new FORMDBContext();
            List<Lists> all = context.Lists.ToList();
            ViewBag.AllListItems = all;
            return View();
        }

        
        
    }
}

