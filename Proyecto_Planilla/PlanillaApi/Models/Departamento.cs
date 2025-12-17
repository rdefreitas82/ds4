using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanillaApi.Models
{
    public class Departamento
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        [Required]
        public string NombreDepartamento { get; set; }
        public string Ubicacion { get; set; }
    }
}
