using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mills_4800.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My name is Thomas Mills and I'm currently taking MIS4200. I love physical fitness, outdoor activities, and am huge gamer nerd.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact information.";

            return View();
        }
    }
}