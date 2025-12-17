using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlanillaWeb.Models;
using PlanillaWeb.Services.Interfaces;
using System.Threading.Tasks;

namespace PlanillaWeb.Controllers
{
    [Route("Empresa/{idEmpresa}/[controller]")]
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadoService _empleadoService;
        private readonly IEmpresaService _empresaService;

        public EmpleadoController(IEmpleadoService empleadoService, IEmpresaService empresaService)
        {
            _empleadoService = empleadoService;
            _empresaService = empresaService;
        }

        // GET: EmpleadoController
        public async Task<ActionResult> Index(int idEmpresa)
        {
            var empleados = await _empleadoService.GetEmpleadosPorEmpresaAsync(idEmpresa);
            var empresa = await _empresaService.GetEmpresaByIdAsync(idEmpresa);
            ViewBag.NombreEmpresa = empresa != null ? empresa.NombreComercial : "Empresa Desconocida";
            ViewBag.IdEmpresa = idEmpresa;
            return View(empleados);
        }

        // GET: EmpleadoController/Details/5
        public async Task<ActionResult> Detalle(int id)
        {
            var empleado = await _empleadoService.GetEmpleadoByIdAsync(id);
            var empresa = await _empresaService.GetEmpresaByIdAsync(empleado.IdEmpresa);
            ViewBag.NombreEmpresa = empresa != null ? empresa.NombreComercial : "Empresa Desconocida";
            return View(empleado);
        }

        // GET: EmpleadoController/Create
        public async Task<ActionResult> Create(int IdEmpresa)
        {
            var modelo = new EmpleadoDto { IdEmpresa = IdEmpresa };
            var empresa = await _empresaService.GetEmpresaByIdAsync(IdEmpresa);
            ViewBag.NombreEmpresa = empresa != null ? empresa.NombreComercial : "Empresa Desconocida";
            return View(modelo);
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmpleadoDto empleado)
        {
            if (ModelState.IsValid)
            {
                var idEmpleado = await _empleadoService.CreateEmpleadoAsync(empleado);
                if (idEmpleado > 0)
                {
                    return RedirectToAction(nameof(Detalle), new { id = idEmpleado });
                }
                ModelState.AddModelError(string.Empty, "No se pudo crear el empleado en la API.");
            }
            return View(empleado);
        }
         
        // GET: EmpleadoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var empleado = await _empleadoService.GetEmpleadoByIdAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return View(empleado);
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, EmpleadoDto empleado)
        {
            if (id != empleado.Id) return BadRequest();
            if (ModelState.IsValid)
            {
                var actualizado = await _empleadoService.UpdateEmpleadoAsync(empleado);
                if (actualizado)
                {
                    return RedirectToAction(nameof(Detalle), new { id = empleado.Id });
                }
                ModelState.AddModelError(string.Empty, "No se pudo actualizar el empleado en la API.");
            }
            return View(empleado);
        }

        // GET: EmpleadoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var empleado = await _empleadoService.GetEmpleadoByIdAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return View(empleado);
        }

        // POST: EmpleadoController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmado(int id, int idEmpresa)
        {
            var exito = await _empleadoService.BorrarEmpleadoAsync(id);
            if (exito)
            {
                return RedirectToAction(nameof(Index), new { idEmpresa = idEmpresa });
            }
            return RedirectToAction(nameof(Delete), new { id = id });
        }
    }
}
