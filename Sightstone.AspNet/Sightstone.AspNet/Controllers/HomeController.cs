using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sightstone.AspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Sightstone.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact the sightstone team.";

            return View();
        }
    }
}