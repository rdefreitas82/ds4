using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Parcial3.Models;

namespace Parcial3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<Preguntas> Parcial3 = new List<Preguntas>();
            string id = null;
            string Pregunta = null;
            string Respuesta = null;

            string connectionString = @"server=localhost; database=RicardoDeFreitas; Trusted_Connection=True; TrustServerCertificate=True";
            SqlConnection conexion = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM RD_Parcial", conexion))
            {
                cmd.CommandType = CommandType.Text;
                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader[0].ToString() ;
                        Pregunta = reader[1].ToString();
                        Respuesta = reader[2].ToString();
                        Parcial3.Add(new Preguntas(id, Pregunta, Respuesta));
                    }

                }
            }
            if (Parcial3 != null)
            {
                ViewBag.Parcial3 = Parcial3;
            }
            else
            {
                ViewBag.Parcial3 = null;
            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}