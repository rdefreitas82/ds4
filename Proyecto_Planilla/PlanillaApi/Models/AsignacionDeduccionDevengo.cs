using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class AsignacionDeduccionDevengo
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public int IdConcepto { get; set; }
        public bool EsDeduccion { get; set; }
        public decimal MontoFijo { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin {  get; set; }
        public int  PagosRestantes { get; set; }
    }
}
