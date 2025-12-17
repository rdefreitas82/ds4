using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class HistorialSalario
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public decimal SalarioAnterior { get; set; }
        public decimal SalarioNuevo { get; set; }
        public DateTime FechaCambio { get; set; }
        public string RazonCambio { get; set; }
    }
}
