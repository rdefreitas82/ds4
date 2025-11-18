using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio20.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.numero = null;
            return View();
        }

        [HttpPost]
        public ActionResult Index(int numero)
        {
            ViewBag.numero = numero;
            return View();
        }
    }
}