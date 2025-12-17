using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class PlanillaDevengo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool EsGravable { get; set; }
        public bool EsRecurrente { get; set; }
        public int IdEmpresa { get; set; }
    }
}
