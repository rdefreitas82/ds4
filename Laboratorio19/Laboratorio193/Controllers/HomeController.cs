using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio193.Controllers
{
    public class HomeController : Controller
    {
        string port = "44345";
        // GET: Home
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                id = 1;
            }
            var url = $"https://localhost:{port}/api/Values/Get/{id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "apllication/jaon";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) ViewBag.error = false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            ViewBag.message = responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {

            }
            return View();
        }
    }
}