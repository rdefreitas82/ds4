using Microsoft.AspNetCore.Mvc;
using PlanillaWeb.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlanillaWeb.Services.Interfaces;

namespace PlanillaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmpresaService _empresaService;

        public HomeController(ILogger<HomeController> logger, IEmpresaService empresaservice)
        {
            _logger = logger;
            _empresaService = empresaservice;
        }

        public async Task<IActionResult> Index()
        {
            var empresas = await _empresaService.GetEmpresaSelectAsync();
            ViewBag.EmpresasItems = new SelectList(empresas, "Id", "NombreComercial");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
