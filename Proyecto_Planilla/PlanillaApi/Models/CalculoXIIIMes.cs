using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class CalculoXIIIMes
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public DateOnly PeriodoInicio { get; set; }
        public DateOnly PeriodoFin { get; set; }
        public DateOnly FechaPago { get; set; }
    }
}
