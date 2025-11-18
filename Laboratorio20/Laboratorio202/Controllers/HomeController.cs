using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio202.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.dimension = null;
            return View();
        }

        [HttpPost]
        public ActionResult Index(int dimension)
        {
            ViewBag.dimension = dimension;
            return View();
        }
    }
}