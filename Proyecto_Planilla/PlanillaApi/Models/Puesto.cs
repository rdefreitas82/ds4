using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class Puesto
    {
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public string NombrePuesto { get; set; }
        public int NivelSalarial { get; set; }
    }
}
