using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class SelectionController : Controller
    {
        // GET: Selection
        public ActionResult Selection1(string Selection1)
        {
            ViewBag.Selection1 = Selection1;
            return View();
        }
        public ActionResult Selection2(string Selection2)
        {
            ViewBag.Selection2 = Selection2;
            return View();
        }
        public ActionResult Selection3(string Selection3)
        {
            ViewBag.Selection3 = Selection3;
            return View();
        }
        public ActionResult Selection()
        {
            return View();
        }
        public ActionResult ConsolePannel(string Selection)
        {
            ViewBag.Selection = Selection;
            return View();
        }
       
    }
}