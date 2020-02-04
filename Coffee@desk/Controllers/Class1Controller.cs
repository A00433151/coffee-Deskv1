using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coffee_desk.Models;

namespace Coffee_desk.Controllers
{
    public class Class1Controller : Controller
    {
        // GET: Class1
        public ActionResult Random()
        {
            var class1 = new Class1() { Name = "shrek" };
            // to return view
            //return View(class1);
            // to redirect
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
        }

        //localhost:44339/Class1/edit?id=2
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}