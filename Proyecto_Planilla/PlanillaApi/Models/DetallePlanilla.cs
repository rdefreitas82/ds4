using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class DetallePlanilla
    {
        public int Id { get; set; }
        public int IdCalculoPlanilla { get; set; }
        public int IdConcepto { get; set; }
        public bool EsDevengo { get; set; }
        public decimal ValorBase { get; set; }
        public decimal PorcentajeOTasa { get; set; }
        public decimal Monto { get; set; }
        public string DescripcionAdicional { get; set; }

    }
}
