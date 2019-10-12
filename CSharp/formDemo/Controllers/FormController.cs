 
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
            FORMDBContext context = new FORMDBContext();
            List<Lists> all = context.Lists.ToList();
            ViewBag.AllListItems = all;

            return View();
        }

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

            return RedirectToAction("NewPage");
        }


        //[HttpGet] ??
        public ActionResult Show()

        {
            FORMDBContext context = new FORMDBContext();
            List<Lists> all = context.Lists.ToList();
            ViewBag.AllListItems = all;
            return View();
        }

        
        public ActionResult NewPage()
        {
            return View();
        }
        
    }
}

