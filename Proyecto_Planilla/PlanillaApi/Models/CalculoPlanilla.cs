using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class CalculoPlanilla
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public DateOnly FechaInicioPeriodo { get; set; }
        public DateOnly FechaFinPeriodo { get; set; }
        public DateOnly FechaPago { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal SalarioHora { get; set; }
        public decimal HorasRegulares { get; set; }
        public decimal TotalDevengos { get; set; }
        public decimal TotalDeducciones { get; set; }
        public decimal SalarioNeto { get; set; }
        public string Estado {  get; set; }
    }
}
