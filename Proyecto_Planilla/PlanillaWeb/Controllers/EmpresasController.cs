using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlanillaWeb.Models;
using PlanillaWeb.Services.Interfaces;
using System.Net.Http;
using System.Text;

namespace PlanillaWeb.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly IEmpresaService _empresaService;

        public EmpresasController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }
        public async Task<IActionResult> Index()
        {
            var empresas = await _empresaService.GetAllEmpresasAsync();
            return View(empresas);
        }

        public async Task<IActionResult> Detalle(int id)
        {
            var empresa = await _empresaService.GetEmpresaByIdAsync(id);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);
        }

        public async Task<IActionResult> Editar(int id)
        {
            var empresa = await _empresaService.GetEmpresaByIdAsync(id);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, EmpresaDto empresa)
        {
            if (id != empresa.Id) return BadRequest();
            if (ModelState.IsValid)
            {
                var update = await _empresaService.UpdateEmpresaAsync(empresa);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(EmpresaDto empresa)
        {
            if (ModelState.IsValid)
            {
                empresa.FechaCreacion = DateTime.Now;
                var nuevoId = await _empresaService.CreateEmpresaAsync(empresa);
                if (nuevoId > 0) return RedirectToAction(nameof(Detalle), new {id = nuevoId});
            }
            return View(empresa);
        }
    }
}

