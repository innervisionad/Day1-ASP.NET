using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Hello";

            return View();
        }
        //getting parameters form the query string
        public ActionResult About(string myName = "", int myNumber = 1)
        {
            ViewBag.Message2 = "Hiya, " + myName + "! you typed in the number " + myNumber + ".";
            return View();
        }
        //getting a parameter via routing
        public ActionResult Contact(int id=1)
        {
            ViewBag.AnotherMessage = "You have just entered the number " + id;

            return View();
        }
    }
}